using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using YogaDBLibrary.Models;

namespace YogaDBLibrary
{
    public partial class YogaDBContext : DbContext
    {
        public YogaDBContext()
            : base("name=YogaDB")
        {
        }

        #region Login Methods
        public Account Register_NewAccount(string firstName, string lastName, string phoneNumber, string email, string password, out string msg)
        {
            msg = "";
            Account newAccount = new Account();
            newAccount.FirstName = firstName;
            newAccount.LastName = lastName;
            newAccount.PhoneNumber = phoneNumber;
            newAccount.Email = email;
            newAccount.Username = email;
            newAccount.Password = password;
            newAccount.StatusId = (int) AccountStatus_Enum.Pending;
            newAccount.TypeId = (int)AccountType_Enum.User;

            Account result = Register_NewAccount(newAccount, out msg);
            return result;
        }


        public Account Register_NewAccount(Account newAccount, out string msg)
        {
            msg = "";
            Account result = null;

            string userName = newAccount.Username;

            Account tmpAccount = Accounts.Where(x => x.Username == userName).FirstOrDefault();

            if(tmpAccount != null)
            {
                msg = "Account with Email " + userName + " is already registered!";                
            }
            else
            {
                try
                {
                    Accounts.Add(newAccount);
                    SaveChanges();
                    result = Accounts.Where(x => x.Username == userName).FirstOrDefault();
                }
                catch(Exception ex)
                {
                    result = null;
                    msg = "Registration of Account with Email " + userName + " has failed!";
                }

            }

            return result;
        }

        #endregion  Login Methods

        #region Admin Methods
        public List<Account> ApproveRequests(List<Pending_Accounts> requests, out string msg)
        {
            List<Account> approved = new List<Account>();
            msg = "";

            foreach(Pending_Accounts appro in requests)
            {
                string tmpMsg = "";
                Account tmpAcc = Approve_PendingAccount(appro, out tmpMsg);

                approved.Add(tmpAcc);

                if (tmpMsg != "") msg += tmpMsg + Environment.NewLine;
            }

            return approved;
        }

        private Account Approve_PendingAccount(Pending_Accounts appro, out string tmpMsg)
        {
            Account account = null;

            // Create a SQL command to execute the sproc     
            var cmd = this.Database.Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            tmpMsg = "";

            cmd.CommandText = "exec dbo.Approve_PendingAccount @AccountId = @AccountId,  @StatusId =  @StatusId, @TypeId = @TypeId,  @MSG = @Result_Message OUTPUT";


            SqlParameter accountIdParameter = new SqlParameter("@AccountId", SqlDbType.Int);
            accountIdParameter.Value = appro.AccountId;


            SqlParameter statusIdParameter = new SqlParameter("@StatusId", SqlDbType.Int);
            statusIdParameter.Value = (int) appro.AccountStatus;


            SqlParameter typeIdParameter = new SqlParameter("@TypeId", SqlDbType.Int);
            typeIdParameter.Value =  (int) appro.AccountType;


            SqlParameter resultMessageParameter = new SqlParameter("@Result_Message", SqlDbType.NVarChar, 1000);
            //resultMessageParameter.Value = tmpMsg;
            resultMessageParameter.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(accountIdParameter);
            cmd.Parameters.Add(statusIdParameter);
            cmd.Parameters.Add(typeIdParameter);
            cmd.Parameters.Add(resultMessageParameter);

            int error = 0;
            string error_msg = "";

            try
            {
                using (var scope = GetTransactionScope())
                {

                    bool opened = OpenConnection();
                    if (opened)
                    {

                        int rs = cmd.ExecuteNonQuery();

                        error = 0;

                        error_msg = (string)resultMessageParameter.Value;

                        this.Status = 1;
                    }
                    scope.Complete();
                }
            }
            catch (SqlException ex3)
            {

                error = 3;
                error_msg = ex3.Message;

                SetStatus(ex3);
            }
            catch (DbEntityValidationException ex2)
            {
                var newException = new FormattedDbEntityValidationException(ex2);


                error = 2;
                error_msg = newException.Message;

                SetStatus(ex2, DatabaseExceptionType.DbEntityValidationException);
            }
            catch (Exception ex)
            {

                error = 1;
                error_msg = ex.Message;

                SetStatus(ex, DatabaseExceptionType.Exception);
            }
            finally
            {

                CloseConnection();
            }
            tmpMsg = error_msg;

            account = Accounts.Where(x => x.AccountId == appro.AccountId).FirstOrDefault();

            return account;
        }


        #endregion Admin Methods

        #region DefaultContext
        public virtual DbSet<Account_Statuses> Account_Statuses { get; set; }
        public virtual DbSet<Account_Types> Account_Types { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employees_Roles> Employees_Roles { get; set; }
        public virtual DbSet<Reservation_Statuses> Reservation_Statuses { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subscription_Statuses> Subscription_Statuses { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Training_Statuses> Training_Statuses { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Pending_Accounts> Pending_Accounts { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account_Statuses>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Account_Statuses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account_Types>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Account_Types)
                .WillCascadeOnDelete(false);
            
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);
            
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);
            /*
            modelBuilder.Entity<Account>()
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasOptional(e => e.User)
                .WithRequired(a => a.Account)
                .WillCascadeOnDelete(false);
            */
            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(19, 2);


            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Trainings)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.TrainerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employees_Roles)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Reservation_Statuses>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Reservation_Statuses)
                .HasForeignKey(e => e.ReservationStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Employees_Roles)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscription_Statuses>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.Subscription_Statuses)
                .HasForeignKey(e => e.SubscriptionStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Training_Statuses>()
                .HasMany(e => e.Trainings)
                .WithRequired(e => e.Training_Statuses)
                .HasForeignKey(e => e.TrainingStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Training>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Training)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Treatment>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.Treatment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Treatment>()
                .HasMany(e => e.Trainings)
                .WithRequired(e => e.Treatment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Subscription)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }

        #endregion DefaultContext


        #region Connection

        public DatabaseExistsStatus CheckIfDatabaseExists()
        {
            try
            {
                bool DbExists = this.Database.Exists();
                if (DbExists)
                {
                    // database is existing
                    return DatabaseExistsStatus.EXISTING;
                }
                else
                {
                    // config is working, but database does not exist
                    return DatabaseExistsStatus.NO_DB;
                }
            }
            catch (Exception ex)
            {
                // no working config
                return DatabaseExistsStatus.NO_CONNECTION;
            }
        }

        public bool OpenConnection()
        {
            try
            {
                if (this.Database.Connection.State == ConnectionState.Closed)
                    this.Database.Connection.Open();
            }
            catch (SqlException ex)
            {
                SetStatus(ex);
            }
            catch (Exception ex2)
            {
                SetStatus(ex2, DatabaseExceptionType.Exception);
            }

            return this.Database.Connection.State == ConnectionState.Open;
        }

        public bool CloseConnection()
        {
            try
            {
                if (this.Database.Connection.State == ConnectionState.Open)
                    this.Database.Connection.Close();
            }
            catch (Exception ex)
            {

            }

            return this.Database.Connection.State == ConnectionState.Closed;
        }

        #endregion Connection

        #region TransactionScope

        public TransactionScope GetTransactionScope()
        {
            //    var scope = new TransactionScope(TransactionScopeOption.Required, new
            //TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.Snapshot });

            var scope = new TransactionScope(TransactionScopeOption.Required, new
                    TransactionOptions
            { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted });

            return scope;
        }



        #endregion TransactionScope


        #region Status

        private DatabaseExceptionType _ExceptionType = DatabaseExceptionType.None;

        public DatabaseExceptionType ExceptionType
        {
            get { return _ExceptionType; }
            set { _ExceptionType = value; }
        }

        private Exception _DbException = null;

        public Exception DbException
        {
            get { return _DbException; }
            set { _DbException = value; }
        }

        private string _Message = "";

        public string Message
        {
            get { return _Message; }
            set { _Message = value; }
        }

        private string _InnerMessage = "";

        public string InnerMessage
        {
            get { return _InnerMessage; }
            set { _InnerMessage = value; }
        }

        private int _Status = 0;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private int _ErrorCode = 0;

        public int ErrorCode
        {
            get { return _ErrorCode; }
            set { _ErrorCode = value; }
        }

        private bool IsDeadlock
        {
            get
            {
                return (this.ErrorCode == SqlRetryErrorCodes.Deadlock);
            }
        }

        public void ResetStatus()
        {
            this.DbException = null;
            this.ExceptionType = DatabaseExceptionType.None;

            this.Message = "";
            this.InnerMessage = "";
            this.Status = 0;
            this.ErrorCode = 0;
        }

        public void SetStatus(SqlException exception)
        {
            this.DbException = exception;
            this.ExceptionType = DatabaseExceptionType.SqlException;

            if (exception.Message != null)
            {
                this.Message = exception.Message;
            }

            if (exception.InnerException != null)
            {
                this.InnerMessage = exception.InnerException.Message;
            }

            this.Status = -1;
            this.ErrorCode = exception.Number;
        }

        public string GetExceptionTypeInfo(DatabaseExceptionType type)
        {
            string info = "";

            switch (type)
            {

                case DatabaseExceptionType.None:
                    info = "";
                    break;
                case DatabaseExceptionType.Exception:
                    info = "Exception";
                    break;
                case DatabaseExceptionType.SqlException:
                    info = "SqlException";
                    break;
                case DatabaseExceptionType.DbUpdateException:
                    info = "An error occurred sending updates to the database.";
                    break;
                case DatabaseExceptionType.DbUpdateConcurrencyException:
                    info = "A database command did not affect the expected number of rows. This usually indicates an optimistic concurrency violation; that is, a row has been changed in the database since it was queried.";
                    break;
                case DatabaseExceptionType.DbEntityValidationException:
                    info = "The save was aborted because validation of entity property values failed.";
                    break;
                case DatabaseExceptionType.NotSupportedException:
                    info = "An attempt was made to use unsupported behavior such as executing multiple asynchronous commands concurrently on the same context instance.";
                    break;
                case DatabaseExceptionType.ObjectDisposedException:
                    info = "The context or connection have been disposed.";
                    break;
                case DatabaseExceptionType.InvalidOperationException:
                    info = "Some error occurred attempting to process entities in the context either before or after sending commands to the database.";
                    break;
                default:
                    info = "";
                    break;
            }

            return info;
        }

        public int GetExceptionErrorCode(Exception exception, DatabaseExceptionType type)
        {
            int code = 0;

            switch (type)
            {

                case DatabaseExceptionType.None:
                    code = 0;
                    break;
                case DatabaseExceptionType.Exception:
                    code = 100;
                    break;
                case DatabaseExceptionType.SqlException:
                    code = ((SqlException)exception).Number;
                    break;
                case DatabaseExceptionType.DbUpdateException:
                    code = 101;
                    break;
                case DatabaseExceptionType.DbUpdateConcurrencyException:
                    code = 102;
                    break;
                case DatabaseExceptionType.DbEntityValidationException:
                    code = 103;
                    break;
                case DatabaseExceptionType.NotSupportedException:
                    code = 104;
                    break;
                case DatabaseExceptionType.ObjectDisposedException:
                    code = 105;
                    break;
                case DatabaseExceptionType.InvalidOperationException:
                    code = 106;
                    break;
                default:
                    code = 0;
                    break;
            }

            return code;
        }


        public void SetStatus(Exception exception, DatabaseExceptionType type)
        {
            this.DbException = exception;
            this.ExceptionType = type;

            if (exception.Message != null)
            {
                this.Message = exception.Message;
            }

            if (type == DatabaseExceptionType.DbEntityValidationException)
            {

                if (exception.InnerException != null)
                {
                    FormattedDbEntityValidationException exp = new FormattedDbEntityValidationException((DbEntityValidationException)exception.InnerException);

                    this.InnerMessage = exp.Message;
                }

                this.Status = -3;
            }
            else
            {
                if (exception.InnerException != null)
                {
                    this.InnerMessage = exception.InnerException.Message;
                }

                this.Status = -2;
            }



            this.ErrorCode = GetExceptionErrorCode(exception, type);
        }

        #endregion Status
    }
}

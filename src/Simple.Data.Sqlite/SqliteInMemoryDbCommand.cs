using System.Data;

namespace Simple.Data.Sqlite
{
    public class SqliteInMemoryDbCommand : IDbCommand
    {
        private readonly IDbCommand innerCommand;

        public SqliteInMemoryDbCommand(IDbCommand innerCommand)
        {
            this.innerCommand = innerCommand;
        }

        public void Dispose()
        {
            innerCommand.Dispose();
        }

        public void Prepare()
        {
            innerCommand.Prepare();
        }

        public void Cancel()
        {
            innerCommand.Cancel();
        }

        public IDbDataParameter CreateParameter()
        {
            return innerCommand.CreateParameter();
        }

        public int ExecuteNonQuery()
        {
            return innerCommand.ExecuteNonQuery();
        }

        public IDataReader ExecuteReader()
        {
            return innerCommand.ExecuteReader();
        }

        public IDataReader ExecuteReader(CommandBehavior behavior)
        {
            return innerCommand.ExecuteReader(behavior);
        }

        public object ExecuteScalar()
        {
            return innerCommand.ExecuteScalar();
        }

        public IDbConnection Connection
        {
            get { return innerCommand.Connection; }
            set { innerCommand.Connection = value; }
        }

        public IDbTransaction Transaction
        {
            get { return innerCommand.Transaction; }
            set { innerCommand.Transaction = value; }
        }

        public string CommandText
        {
            get { return innerCommand.CommandText; }
            set { innerCommand.CommandText = value; }
        }

        public int CommandTimeout
        {
            get { return innerCommand.CommandTimeout; }
            set { innerCommand.CommandTimeout = value; }
        }

        public CommandType CommandType
        {
            get { return innerCommand.CommandType; }
            set { innerCommand.CommandType = value; }
        }

        public IDataParameterCollection Parameters
        {
            get { return innerCommand.Parameters; }
        }

        public UpdateRowSource UpdatedRowSource
        {
            get { return innerCommand.UpdatedRowSource; }
            set { innerCommand.UpdatedRowSource = value; }
        }
    }
}
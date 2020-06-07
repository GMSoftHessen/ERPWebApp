

namespace BusinessLayer.Customize
{
    public class <%= tableName %>BO
    {
        <%= tableName %>Repository _<%= tableName %>Repository;
    public <%= tableName %>BO(<%= tableName %>Repository <%= tableName %>Repository) 
        {
            _<%= tableName %>Repository = <%= tableName %>Repository;
        }
    }
}
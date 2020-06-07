


namespace BusinessLayer.Customize
{
    public partial class <%= tableName %>ViewModel 
    {
        <%= tableName %>BO _<%= tableName %>customerBO;
        public <%= tableName %>ViewModel(<%= tableName %>BO <%= tableName %>BO) 
        {
            _ <%= tableName %> BO = <%= tableName %>BO;
        }
    }
}

namespace Constans.DBRepo
{
    public  static class Query
    {
        public const string getDate = @"SELECT getdate()";
        public const string GetPerson_AdressFULL = @"

SELECT be.BusinessEntityID
 FROM Person.Person p	LEFT JOIN Person.BusinessEntity be ON p.BusinessEntityID = be.BusinessEntityID
";

        
      
    }
}

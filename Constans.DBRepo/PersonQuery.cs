namespace Constans.DBRepo
{
    public static class PersonQuery
    {
        public const string getDate = @"SELECT getdate()";
        public const string GetPerson_AdressFULL = @"SELECT be.BusinessEntityID FROM Person.Person p LEFT JOIN Person.BusinessEntity be ON p.BusinessEntityID = be.BusinessEntityID";

        public const string getPerson = @"  SELECT * FROM Person p JOIN Adres a  ON P.IDPerson = A.PersonID";

        public const string getPersonByID = @"SELECT * FROM Person p JOIN Adres a  ON P.IDPerson = A.PersonID where P.IDPerson = @PersonID";
        //p.Name , a.pERSONidaaa  , a.City

    }
}

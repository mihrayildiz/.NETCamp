namespace Intro.Entities;

public class BaseCustomer
{
    public int Id { get; set; }
    public string CustomerNumber { get; set; }
}

//ister bireysel ister şirket müşterisi olsun her iki tipte de bu bilgiler var dolayısıyla genel bir class oldu ve inherit işlemi yapıldı
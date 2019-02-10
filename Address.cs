using System;
namespace Assignment01
{
     public struct Address
    {
         private string roadInfor;
         private string addressEmail;
         
         public string RoadInfor { get { return roadInfor; } }
         public string AddressEmail { get { return addressEmail; } }
         
         public Address(string road, string email)
         {
            roadInfor = road;
            addressEmail = email;
         }
}
}

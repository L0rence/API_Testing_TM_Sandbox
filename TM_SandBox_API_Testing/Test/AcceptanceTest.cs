using NUnit.Framework;
using TM_SandBox_API_Testing.DTO;

namespace TM_SandBox_API_Testing
{
    public class Tests
    {
        [Test, Order(1)]
        public void VerifyName()
        {
            var demo = new Demo<ListOfUsersDTO>();
            var user = demo.GetUser("v1/Categories/6327/Details.json?catalogue=false");
            System.Console.WriteLine("*******************             ******************* ");
            System.Console.WriteLine("Name is : " + user.Name);
            System.Console.WriteLine("*******************             ******************* ");
            Assert.AreEqual("Basic", user.Promotions[0].Name);
            Assert.AreEqual("Carbon credits", user.Name);


        }

        [Test, Order(2)]
        public void VerifyCanRelist()
        {
            var demo = new Demo<ListOfUsersDTO>();
            var user = demo.GetUser("v1/Categories/6327/Details.json?catalogue=false");
            System.Console.WriteLine("*******************             ******************* ");
            System.Console.WriteLine("CanRelist : " + user.CanRelist);
            System.Console.WriteLine("*******************             ******************* ");
            Assert.IsTrue(user.CanRelist);
        }

        [Test, Order(3)]
        public void VerifyGallery()
        {
            var demo = new Demo<ListOfUsersDTO>();
            var user = demo.GetUser("v1/Categories/6327/Details.json?catalogue=false");
            // Printing the output at Console 
            System.Console.WriteLine("*******************             ******************* ");
            System.Console.WriteLine("Gallery and Description " + user.Promotions[1].Name  + " ==>> : "+ user.Promotions[1].Description);
            System.Console.WriteLine("*******************             ******************* ");

            Assert.AreEqual("Gallery", user.Promotions[1].Name);
            Assert.AreEqual("Good position in category", user.Promotions[1].Description);

        }


    }
}

using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass to the method
        string CustomerForename = "Steve";
        string CustomerSurname = "Jobs";
        string CustomerDOB = DateTime.Now.Date.ToString();
        string CustomerEmail = "Stevejobs@gmail.com";
        string CustomerTel = "07561091607";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]

        public void CustomerIDPropertyOK()
        {
            //create an instance for a class that needs to be created 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property 
            Int32 TestData = 1;
            //assign data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]

        public void CustomerForenamePropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            String TestData = "Steve";
            //assing data to the property
            AnCustomer.CustomerForename = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerForename, TestData);

        }

        [TestMethod]

        public void CustomerSurnamePropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            String TestData = "Jobs";
            //assing data to the property
            AnCustomer.CustomerSurname = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerSurname, TestData);
        }

        [TestMethod]

        public void CustomerEmailPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            string TestData = "Stevejob@gmail.com";
            //assing data to the property
            AnCustomer.CustomerEmail = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);

        }

        [TestMethod]

        public void CustomerTelPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            String TestData = "07561091607";
            //assing data to the property
            AnCustomer.CustomerTel = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerTel, TestData);
        }

        [TestMethod]

        public void CustomerMembershipPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            Boolean TestData = true;
            //assing data to the property
            AnCustomer.CustomerMembership = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerMembership, TestData);
        }

        [TestMethod]

        public void CustomerDOBPropertyOK()
        {
            //create an instance for a class that needs to be created
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //assing data to the property
            AnCustomer.CustomerDOB = TestData;
            //test to see that two values are the same
            Assert.AreEqual(AnCustomer.CustomerDOB, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean vairable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer ID
            if (AnCustomer.CustomerID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.CustomerDOB != Convert.ToDateTime("01/01/2001"))
            {
                OK = false;
            }
            //test to see if resut is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerForenameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.CustomerForename != "Zhill")
            {
                OK = false;

            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerSurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.CustomerSurname != "Rafic")
            {
                OK = false;
            }
            //test tot see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.CustomerEmail != "zhill@gmail.com")
            {
                OK = false;
            }
            //test tot see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerTelFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.CustomerTel != "07867509813")
            {
                OK = false;
            }
            //test tot see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerMembershipFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.CustomerMembership != true)
            {
                OK = false;
            }
            //test tot see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store anu error message
            String Error = "";
            //invoke the method 
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store anu error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = ""; // this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = "a"; // this should br ok
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = "aa"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = "aaaaa"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = "aaaaaa"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = "aaa"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = "aaaaaaa"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerForenameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string customerforename = ""; // this should be fail
            customerforename = customerforename.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(customerforename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string vairable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname,CustomerDOB,CustomerEmail,CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");




        }

    }
}

    
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
            string CustomerForename = ""; // this should be fail
            CustomerForename = CustomerForename.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
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

        [TestMethod]
        public void CustomerDOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string vairable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string vairable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is more 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string vairable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is more 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string vairable
            string CustomerDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerDOBInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value
            string CustomerDOB = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerSurname = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerSurnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerSurname = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerSurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerSurname = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerSurname = "aaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerSurname = "aaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnamePlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerSurname = "aaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerSurname = "aaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerEmail = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerTel = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTel = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTel = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTel = "";
            CustomerTel = CustomerTel.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTel = "";
            CustomerTel = CustomerTel.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerTel = "";
            CustomerTel = CustomerTel.PadRight(51, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerTelMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerTel = "";
            CustomerTel = CustomerTel.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(CustomerForename, CustomerSurname, CustomerDOB, CustomerEmail, CustomerTel);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}

    
using System;
using System.Text;
using System.Web;

namespace CCP
{
    /// <summary>
    /// Summary description for GetData
    /// </summary>
    public class GetData : IHttpHandler
    {
        StringBuilder sbRecord = new StringBuilder();
        int intNoRecs;

        public void ProcessRequest(HttpContext context)
        {
            CustomerDetails[] arrCustomerDetails;
            arrCustomerDetails = Get();
            int Watchlist = 1;

            intNoRecs = arrCustomerDetails.Length;
            if (intNoRecs == 0)
            {
                context.Response.Write("NoRecFound");
            }
            else
            {
                CustomerDetails objCustomerDetails;
                sbRecord.Clear();
                sbRecord.Append("RecFound^^" + intNoRecs.ToString());
                String strAgentName = "";

                for (Int32 i = 0; i < arrCustomerDetails.Length; i++)
                {
                    objCustomerDetails = arrCustomerDetails[i];
                    strAgentName = objCustomerDetails.AgentName;

                    string debugString = objCustomerDetails.debugtext;

                    sbRecord.Append("^^" + objCustomerDetails.UserName
                        + "^^" + objCustomerDetails.Password
                        + "^^" + objCustomerDetails.LogID
                        + "^^" + objCustomerDetails.LoginType
                        + "^^" + objCustomerDetails.CustID.ToString()
                        + "^^" + objCustomerDetails.CompanyName
                        + "^^" + objCustomerDetails.TradingName
                        + "^^" + objCustomerDetails.Email
                        + "^^" + objCustomerDetails.VATNumber.ToString()
                        + "^^" + objCustomerDetails.CreditLimit.ToString()
                        + "^^" + objCustomerDetails.PayTermID.ToString()
                        + "^^" + objCustomerDetails.PaymentTerm
                        + "^^" + strAgentName
                        + "^^" + objCustomerDetails.SalesChannelID.ToString()
                        + "^^" + objCustomerDetails.SalesChannelName
                        + "^^" + objCustomerDetails.SageAccount
                        + "^^" + Watchlist
                        + "^^" + objCustomerDetails.BrandName
                        );
                }
            }
            context.Response.Write(sbRecord);
        }


        public CustomerDetails[] Get()
        {
            //This function is where we would populate from the Database - in this test case the function will return 1 Customer
            CustomerDetails[] arrCustomer;
            arrCustomer = new CustomerDetails[1];

            CustomerDetails objCustomer;

            for (Int32 i = 0; i < arrCustomer.Length; i++)
            {
                objCustomer = new CustomerDetails();
                objCustomer.CustID = 1;
                objCustomer.CompanyName = "Test Customer " + i;
                objCustomer.BrandName = "A Brand Name " + i;
                objCustomer.TradingName = "A Trading Name " + i;
                objCustomer.VATNumber = "GB123456789";
                objCustomer.CreditLimit = 5000;
                objCustomer.AgentID = 0;
                objCustomer.AgentName = "";
                objCustomer.Email = "mail@example.com";
                objCustomer.PayTermID = 1;
                objCustomer.PaymentTerm = "30 Days Credit";
                objCustomer.SalesChannelID = 1;
                objCustomer.SalesChannelName = "Test Sales Channel";
                objCustomer.CountryID = 1;
                objCustomer.CountryName = "UK";
                objCustomer.LogID = 96548;
                objCustomer.UserName = "username";
                objCustomer.Password = "password";
                objCustomer.LoginType = "Manager";
                objCustomer.StatusID = StatusID.Enabled;
                objCustomer.SageAccount = "test12345";
                arrCustomer[i] = objCustomer;
            }

            return arrCustomer;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


        public class CustomerDetails
        {
            #region Variables

            private int intCustID;
            private String strCompanyName;
            private String strBrandName;
            private String strTradName;
            private int strLastOrderId;
            private String strVatNo;
            private Single sCreditLimit;
            private int intAgentID;
            private String strAgentName;
            private String strEmail;
            private int intPayTermID;
            private String strPaymentTerm;
            private int intSalesChannelID;
            private String strSalesChannelName;
            private int intCountryID;
            private String strCountryName;
            private int intLogID;
            private String strUserName;
            private String strPassword;
            private String strLoginType;
            private String strAddress1;
            private String strAddress2;
            private String strPostcode;
            private String strTownName;
            private String strRegionName;
            private String strFirstName;
            private String strLastName;
            private String strSageAccount;
            private String strNumber;
            private String strSageNominalCodeID;

            private string strSalesNominalCode;
            private string strBankAccount;

            private int intPreOrder;
            private Boolean blnIsStockBox;
            private StatusID enumStatusID;


            #endregion

            public CustomerDetails()
            {

            }

            public CustomerDetails(int CustID, String CompanyName, String BrandName, String TradingName, String VATNumber,
                    Single CreditLimit, int AgentID, String AgentName, String Email, int PayTermID, String PaymentTerm,
                    int SalesChannelID, String SalesChannelName, int CountryID, String CountryName,
                    int LoginID, String UserName, String Password, String LoginType, String Address1, String Address2,
                    String Postcode, String TownName, String RegionName, String Number,
                    String FirstName, String LastName, String SageAccount, String SageNominalCodeID, int PreOrder, string SalesNominalID, string BankAccountID, Boolean IsStockbox, StatusID StatusID)
            {
                intCustID = CustID;
                strCompanyName = CompanyName;
                strBrandName = BrandName;
                strTradName = TradingName;
                strVatNo = VATNumber;
                sCreditLimit = CreditLimit;
                intAgentID = AgentID;
                strAgentName = AgentName;
                strEmail = Email;
                intPayTermID = PayTermID;
                strPaymentTerm = PaymentTerm;
                intSalesChannelID = SalesChannelID;
                strSalesChannelName = SalesChannelName;
                intCountryID = CountryID;
                strCountryName = CountryName;
                intLogID = LoginID;
                strUserName = UserName;
                strPassword = Password;
                strLoginType = LoginType;
                strAddress1 = Address1;
                strAddress2 = Address2;
                strPostcode = Postcode;
                strTownName = TownName;
                strRegionName = RegionName;
                strFirstName = FirstName;
                strLastName = LastName;
                strNumber = Number;
                strSageAccount = SageAccount;
                strSageNominalCodeID = SageNominalCodeID;

                strSalesNominalCode = SalesNominalID;
                strBankAccount = BankAccountID;

                intPreOrder = PreOrder;
                blnIsStockBox = IsStockbox;
                enumStatusID = StatusID;

            }

            #region Properties

            public int CustID
            {
                get { return intCustID; }
                set { intCustID = value; }
            }

            public String CompanyName
            {
                get { return strCompanyName; }
                set { strCompanyName = value; }
            }

            public String BrandName
            {
                get { return strBrandName; }
                set { strBrandName = value; }
            }

            public String TradingName
            {
                get { return strTradName; }
                set { strTradName = value; }
            }

            public int LastOrderId
            {
                get { return strLastOrderId; }
                set { strLastOrderId = value; }
            }

            public String VATNumber
            {
                get { return strVatNo; }
                set { strVatNo = value; }
            }

            public Single CreditLimit
            {
                get { return sCreditLimit; }
                set { sCreditLimit = value; }
            }

            public int AgentID
            {
                get { return intAgentID; }
                set { intAgentID = value; }
            }

            public String AgentName
            {
                get { return strAgentName; }
                set { strAgentName = value; }
            }

            public String Email
            {
                get { return strEmail; }
                set { strEmail = value; }
            }

            public int PayTermID
            {
                get { return intPayTermID; }
                set { intPayTermID = value; }
            }

            public String PaymentTerm
            {
                get { return strPaymentTerm; }
                set { strPaymentTerm = value; }
            }

            public int SalesChannelID
            {
                get { return intSalesChannelID; }
                set { intSalesChannelID = value; }
            }

            public String SalesChannelName
            {
                get { return strSalesChannelName; }
                set { strSalesChannelName = value; }
            }

            public int CountryID
            {
                get { return intCountryID; }
                set { intCountryID = value; }
            }

            public String CountryName
            {
                get { return strCountryName; }
                set { strCountryName = value; }
            }

            public int LogID
            {
                get { return intLogID; }
                set { intLogID = value; }
            }

            public String UserName
            {
                get { return strUserName; }
                set { strUserName = value; }
            }

            public String Password
            {
                get { return strPassword; }
                set { strPassword = value; }
            }

            public String LoginType
            {
                get { return strLoginType; }
                set { strLoginType = value; }
            }

            public String Address1
            {
                get { return strAddress1; }
                set { strAddress1 = value; }
            }

            public String Address2
            {
                get { return strAddress2; }
                set { strAddress2 = value; }
            }

            public String Postcode
            {
                get { return strPostcode; }
                set { strPostcode = value; }
            }

            public String TownName
            {
                get { return strTownName; }
                set { strTownName = value; }
            }

            public String RegionName
            {
                get { return strRegionName; }
                set { strRegionName = value; }
            }

            public String FirstName
            {
                get { return strFirstName; }
                set { strFirstName = value; }
            }

            public String LastName
            {
                get { return strLastName; }
                set { strLastName = value; }
            }

            public String Number
            {
                get { return strNumber; }
                set { strNumber = value; }
            }

            public String SageAccount
            {
                get { return strSageAccount; }
                set { strSageAccount = value; }
            }

            public String SageNominalCodeID
            {
                get { return strSageNominalCodeID; }
                set { strSageNominalCodeID = value; }
            }

            public string SalesNominalCodeID
            {
                get { return strSalesNominalCode; }
                set { strSalesNominalCode = value; }
            }

            public string BankAccountID
            {
                get { return strBankAccount; }
                set { strBankAccount = value; }
            }


            public int PreOrder
            {
                get { return intPreOrder; }
                set { intPreOrder = value; }
            }

            public Boolean IsStockbox
            {
                get { return blnIsStockBox; }
                set { blnIsStockBox = value; }
            }

            public StatusID StatusID
            {
                get { return enumStatusID; }
                set { enumStatusID = value; }
            }


            public int LastOrderID
            {
                get;
                set;
            }

            public DateTime LastOrderDate
            {
                get;
                set;
            }

            #endregion
        }


        public enum StatusID
        {
            Completed = 8,
            PartCancel = 7,
            PartUpdate = 4,
            PartAdd = 3,
            Enabled = 1,
            Disabled = 0,
            Deleted = -1,
            Archived = -2,
            PreDelete = -3
        }
    }
}
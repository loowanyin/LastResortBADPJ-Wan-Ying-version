using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class FAQ
{
    //Private string _connStr = Properties.Settings.Default.DBConnStr;

    //System.Configuration.ConnectionStringSettings _connStr;
    string _connStr = ConfigurationManager.ConnectionStrings["FAQDBContext"].ConnectionString;
    private string _faqID = null;
    private string _faqGender = string.Empty;
    private string _faqEmail = ""; // this is another way to specify empty string
    private string _faqPhoneNumber = string.Empty;
    private string _faqYourQuestion = string.Empty;


    // Default constructor
    public FAQ()
    {
    }

    // Constructor that take in all data required to build a faq object
    public FAQ(string faqID, string faqGender, string faqEmail,
               string faqPhoneNumber, string faqYourQuestion)
    {
        _faqID = faqID;
        _faqGender = faqGender;
        _faqEmail = faqEmail;
        _faqPhoneNumber = faqPhoneNumber;
        _faqYourQuestion = faqYourQuestion;
    }

    // Constructor that take in all except product ID
    public FAQ(string faqGender, string faqEmail, 
            string faqPhoneNumber, string faqYourQuestion)
        : this(null, faqGender, faqEmail, faqPhoneNumber, faqYourQuestion)

    {
    }
    // Constructor that take in only Product ID. The other attributes will be set to 0 or empty.
    public FAQ(string faqID)
        : this(faqID, "", "", "", "")
    {

    }
    // Get/Set the attributes of the Product object.
    // Note the attribute name (e.g. Product_ID) is same as the actual database field name.
    // This is for ease of referencing.
    public string faq_ID
    {
        get { return _faqID; }
        set { _faqID = value; }

    }
    public string faq_Gender
    {
        get { return _faqGender; }
        set { _faqGender = value; }
    }
    public string faq_Email
    {
        get { return _faqEmail; }
        set { _faqEmail = value; }
    }
    public string faq_PhoneNumber
    {
        get { return _faqPhoneNumber; }
        set { _faqPhoneNumber = value; }
    }
    public string faq_YourQuestion
    {
        get { return _faqYourQuestion; }
        set { _faqYourQuestion = value; }
    }

    //Below as the Class methods for some DB operations. 
    public FAQ getFAQ(string faqID)
    {

        FAQ faqDetail = null;

        string faq_ID, faq_Gender, faq_Email, faq_PhoneNumber, faq_YourQuestion;


        string queryStr = "SELECT * FROM FAQ WHERE FAQ_ID = @FAQID";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);
        cmd.Parameters.AddWithValue("@FAQID", faqID);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            faq_ID = dr["FAQ_ID"].ToString();
            faq_Gender = dr["FAQ_Gender"].ToString();
            faq_Email = dr["FAQ_Email"].ToString();
            faq_PhoneNumber = dr["FAQ_PhoneNumber"].ToString();
            faq_YourQuestion = dr["FAQ_YourQuestion"].ToString();

            faqDetail = new FAQ(faqID, faq_Gender, faq_Email, faq_PhoneNumber, faq_YourQuestion);
        }

    }

    public List<FAQ> getFAQAll()
    {
        List<FAQ> FAQList = new List<FAQ>();

        string faqID, faq_Gender, faq_Email, faq_PhoneNumber, faq_YourQuestion;

        string queryStr = "SELECT * FROM Products Order By Product_Name";

        SqlConnection conn = new SqlConnection(_connStr);
        SqlCommand cmd = new SqlCommand(queryStr, conn);

        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            faq_ID = dr["faq_ID"].ToString();
            faq_Gender = dr["faq_Gender"].ToString();
            faq_Email = dr["faq_Email"].ToString();
            faq_PhoneNumber = dr["faq_PhoneNumber"].ToString();
            faq_YourQuestion = dr["faq_YourQuestion"].ToString();
            FAQ a = new FAQ(faq_ID, faq_Gender, faq_Email, faq_PhoneNumber, faq_YourQuestion);
            FAQList.Add(a);
        }

        conn.Close();
        dr.Close();
        dr.Dispose();

        return FAQList;
    }
}

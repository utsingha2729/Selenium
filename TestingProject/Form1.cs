using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingProject
{
    public partial class Form1 : Form
    {
        //ChromeDriver Driverobj;
        IWebDriver Driverobj;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChromeStart_Click(object sender, EventArgs e)
        {
            //Driverobj = new ChromeDriver();
            Driverobj = new OpenQA.Selenium.Chrome.ChromeDriver();

        }

        private void BtnNavigate_Click(object sender, EventArgs e)
        {
            Driverobj.Url = "file:///D:/Users/Learning/Downloads/HTML%20Samples/SampleForm.html";

            //Driverobj.Url = "http://w3Schools.com";

        }
        

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Driverobj.Navigate().Refresh();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Driverobj.Close();
            Driverobj.Quit();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            Driverobj.Navigate().Forward();
        }

        private void BtnBackward_Click(object sender, EventArgs e)
        {
            Driverobj.Navigate().Back();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            Driverobj.Manage().Window.Maximize();
        }

        private void BtnMinimise_Click(object sender, EventArgs e)
        {
            Driverobj.Manage().Window.Minimize();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //IWebElement ElementObj = Driverobj.FindElement(By.Name("q"));

            //ElementObj.Clear();
            //ElementObj.SendKeys("Selenium for Developers");
            //ElementObj.Submit();

            //Drop Down List
            SelectElement SelectionObj = new SelectElement(Driverobj.FindElement(By.Id("Languages")));
            SelectionObj.SelectByText("Python");

            SelectionObj.SelectByIndex(2);

            IList<IWebElement> ListSize = SelectionObj.Options;

            int iListSize = ListSize.Count;

            for (int i = 0; i < iListSize; i++)
            {
                String SelectedValue = SelectionObj.Options.ElementAt(i).Text;

                MessageBox.Show("Value of Selected item is : " + SelectedValue);

                if(SelectedValue.Equals("C++"))
                {
                    SelectionObj.SelectByIndex(i);
                    break;
                }
            }


            //Table
            var ElementTable = Driverobj.FindElement(By.Id("mytable"));

            List<IWebElement> trElements = new List<IWebElement>(ElementTable.FindElements(By.TagName("tr")));
            String strRowData = "";
            foreach (var trElement in trElements)
            {
                List<IWebElement> lstTdItem = new List<IWebElement>(trElement.FindElements(By.TagName("td")));

                foreach (var elemTd in lstTdItem)
                {
                    strRowData = strRowData + elemTd.Text + "\t\t";
                }
            }
            
        }
    }
}

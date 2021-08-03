
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement nameElement;
    static IWebElement idElement;
    static IWebElement classElement;
    static IWebElement cssPathElement;
    static IWebElement xPathsElement;
    static void Main()
    {
        string url = "https://testing.todorvachev.com/";
        string name = "myName";
        string ID = "testImage";
        string className = "testClass";
        string cssPath = "#post-108 > div > figure > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";

        

        driver.Navigate().GoToUrl(url + "/name/");

        nameElement = driver.FindElement(By.Name(name));



        driver.Navigate().GoToUrl(url + "/class-name/");

         classElement = driver.FindElement(By.ClassName(className));



        driver.Navigate().GoToUrl(url + "/css-path/");

         cssPathElement = driver.FindElement(By.CssSelector(cssPath));



        driver.Navigate().GoToUrl(url + "/css-path/");

         xPathsElement = driver.FindElement(By.XPath(xPath));


        try
        {
            driver.Navigate().GoToUrl(url + "/id/");

            idElement = driver.FindElement(By.Id(ID));

            if (idElement.Displayed)
            {
                RedMSG("Yes! I can see the element");
            }


        }
        catch (NoSuchElementException)
        {

            GreenMsg("Something went wrong. element is not there");
        }



        driver.Quit();
    }

    private static void GreenMsg(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void RedMSG(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

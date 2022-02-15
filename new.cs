class new{
   static void Main(){
       Console.WriteLine("Hello, World!");
       IWebDriver driver = new ChromeDriver();
       IWebDriver drievr2 = new InternetExplorerDriver();
       driver.Navigate().GoToUrl("https://www.google.com/");
       Thread.Sleep(2000);
       driver.Quit();
   }
}


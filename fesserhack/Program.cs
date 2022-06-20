using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace fesserhack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.Title = "Fesser hack";

            Console.WriteLine(@"a. XP farm 
b. Auto tabel
        ");

            answer = Console.ReadLine();
            if (answer == "a")
            {
                Console.Clear();
                do_xpfarm();
            }
            else
            {
                Console.WriteLine("Not valid or coming soon");
                Console.ReadLine();
            }

        }



        static void do_xpfarm()
        {
            int num1;
            int num2;
            int answer;
            int done = 0;
            int spo = 100;
            int naa = 0;
            int doneopgave = 0;
            string username = null;
            string safemode;

            Console.Title = "Fesser hack        XP FARMER";




            Console.WriteLine("Safemode?? y/n (Langsommere program hvis du har langsomt net eller pc");

            safemode = Console.ReadLine();
            if (safemode == "y")
            {
                safemode_do();
            }
            Console.Clear();
            Console.WriteLine("Ikke safemode");
            Console.WriteLine("Unilogin Brugernavn? (Blurred)");
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;                  // Hide the username 
                username += key.KeyChar;
            }

            Console.WriteLine("Unilogin Kode? (Blurred)");
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;                  // Hide the password 
                password += key.KeyChar;
            }


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://matematikfessor.dk/"); // accepts cookies
            Console.Clear();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div[2]/button[2]")).Click(); // accepts cookies so it wont fuck it up later

            Console.WriteLine("Cookies accepted");

            Console.Clear();

            driver.Navigate().GoToUrl("https://broker.unilogin.dk/auth/realms/broker/protocol/saml-stil?SAMLRequest=nZLBbsIwEER%2FJfI9cRIgEAuQaDkUiaoI0h56qTaOAYvETr1ORf%2B%2BToCWqhKHnizvet7OrDxGqMqazRq7V2vx3gi03rEqFbKuMSGNUUwDSmQKKoHMcraZPS5ZHISsNtpqrktyJbmtAERhrNSKeIv5hLz1BgmPBqmIIO4Xw2LbTyKeRtthfxQn%2BTbMixHwVKRpwon3Igw65YQ4kJMjNmKh0IKyrhTGsR8mfjTK4ogNYhb1Xok3d2mkAtup9tbWyCjNjT4IEzRKlnonVVAcKLj01AgoKzy36SUabTP5DuNCzi7m77XCphJmI8yH5OJ5vfzBgy0BW7r%2FjUdZ1aVoQbTSRVOKoN7XHZji6Yx94NhVAX1E7bvxx0%2Firc4u7qQqpNrd3m1%2BeoTsIctW%2Fuppk5HpuKWzbldm%2Bm%2BLlbBQgIU%2FDsf0mn%2B6%2Ff5M0y8%3D&RelayState=https%3A%2F%2Fatlas.uni-login.dk%2Funilogin%2Flogin.cgi%3Fid%3Dedulab%26path%3DaHR0cHM6Ly9sb2dpbi5tYXRlbWF0aWtmZXNzb3IuZGsvZXh0L3VuaWxvZ2luL2xvZ2luX2NhbGxiYWNrLz9yPWh0dHBzJTNBJTJGJTJGd3d3Lm1hdGVtYXRpa2Zlc3Nvci5kayUyRg%253D%253D%26auth%3D0a0212afeada128f9e719da9c10e879f&SigAlg=http%3A%2F%2Fwww.w3.org%2F2001%2F04%2Fxmldsig-more%23rsa-sha256&Signature=ESYbffCdeeC%2FJLfpZW1u2rzInLIw4%2BCDH%2F%2Ff55mZG9kAZsc0MpacteX2w4Fdm9OoRP2Tl5%2F%2BdC6zZnKFYqkz6RpPKGpCsqXPC9qhOgSKK%2FYKsWiNwbQY%2FTAT6XdNFVd5T%2FxEBQM9eD%2BFiiFsGOKpIao%2F%2FmEnydopSjWdJjUR%2BmmY7kKjGCVfPQ1GzXwGNtDWgCbepX2%2B2QebTBkUWVxbjLFzj4%2Boyex7cYEwmExa8h0%2BX6WGbVNeLBqJGZHTxlZqPmOa0N%2BSTKzDc1jBJLIps%2Bn8G3QvrVR%2F1tX6uiYpWw1ozneb1%2BTaSIXT9szcH2ZdRMKcPzE5vKcM1dWEywAnMQ%3D%3D");
            Thread.Sleep(2);
            driver.FindElement(By.XPath("/html/body/main/div/div/form/div[1]/input")).SendKeys(username); // puts the username
            Console.WriteLine("Filled username");
            driver.FindElement(By.XPath("/html/body/main/div/div/form/nav/button")).Click(); // clicks login 
            Thread.Sleep(1);
            driver.FindElement(By.XPath("/html/body/main/div/div/form/div[1]/input")).SendKeys(password); // puts the password
            Console.WriteLine("Filled Password");
            Thread.Sleep(1);
            driver.FindElement(By.XPath("/html/body/main/div/div/form/nav/div/div[1]/button")).Click(); // clicking loggin
            Console.WriteLine("Logged in");
            Thread.Sleep(4000);
            Console.Clear();
            while (true)
            {                       // https://www.matematikfessor.dk/test/trialexam/?id=5458&grade=false&history=true
                Console.Clear();
                driver.Navigate().GoToUrl("https://www.matematikfessor.dk/test/trialexam/?id=5458&grade=false&history=true");
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/p/span")).Click();
                Thread.Sleep(800);
                try
                {
                    driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/aside/ul/li[5]"));

                    spo = 5;
                }
                catch (Exception)
                {
                    naa = naa + 1;

                }

                if (spo == 100)
                {
                    try
                    {
                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/aside/ul/li[4]"));
                        spo = 4;
                    }
                    catch (Exception)
                    {
                        naa = naa + 1;
                    }

                }

                if (spo == 100)
                {
                    try
                    {
                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/aside/ul/li[3]"));
                        spo = 3;            // if there is 3 answers
                    }
                    catch (Exception)
                    {
                        spo = 2; // if 2 idk but i just added
                    }
                }

                Thread.Sleep(400);
                int tid_tid = 0;
                int failed = 0;
                var tid = Stopwatch.StartNew();
                try
                {
                    for (int i = 0; i < spo; i++)
                    {
                        doneopgave = doneopgave + 1;

                        Thread.Sleep(700);

                        IWebElement tal1 = driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[2]/div/div/p[3]/span[2]/span/span/span[1]/span"));
                        num1 = Convert.ToInt32(tal1.Text);      // getting num 1 and converting it

                        IWebElement tal2 = driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[2]/div/div/p[3]/span[2]/span/span/span[5]/span"));
                        num2 = Convert.ToInt32(tal2.Text);      // getting num 2 and converting it
                        string ans;
                        answer = num2 - num1;
                        ans = Convert.ToString(answer);

                        tid.Stop();
                        Console.WriteLine("Tal 1 : " + num1);
                        Console.WriteLine("Tal 2 : " + num2);
                        Console.WriteLine("Answer = " + answer);
                        Console.WriteLine("Opgaver klarede (set): " + done);
                        Console.WriteLine("Opgaver klared i alt: " + doneopgave);
                        Console.WriteLine("Opgave klarede det tog: " + tid.ElapsedMilliseconds + " MS");
                        Console.WriteLine("Fejlede : " + failed);

                        Thread.Sleep(350);
                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[3]/div/p/input")).SendKeys(ans);

                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/button")).Click();

                        Thread.Sleep(2000);
                        Console.Clear();
                        int regn;
                        regn = Convert.ToInt32(tid.ElapsedMilliseconds);
                        tid_tid = regn + tid_tid;

                    }
                    Console.WriteLine("Opgave færdig det tog: " + tid_tid + " MS");
                    spo = 100;

                    driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/span/button")).Click();
                    Thread.Sleep(1);
                    driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/div[2]/article/p/button[1]")).Click();

                    done = done + 1;
                }
                catch (Exception)
                {
                    failed = failed + 1;
                }
            }
        }








        static void safemode_do()
        {
            int num1;
            int num2;
            int answer;     // safemode. Samme kode men langsommere
            int done = 0;
            int spo = 100;
            int naa = 0;
            int doneopgave = 0;


            Console.Title = "Fesser hack        XP FARMER    SAFEMODE";

            Console.WriteLine("Unilogin Brugernavn? (Blurred)");
            string username = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;                  // Hide the username 
                username += key.KeyChar;
            }

            Console.WriteLine("Unilogin Kode? (Blurred)");
            string password = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;                  // Hide the password 
                password += key.KeyChar;
            }


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://matematikfessor.dk/"); // accepts cookies
            Console.Clear();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/div[2]/button[2]")).Click(); // accepts cookies so it wont fuck it up later

            Console.WriteLine("Cookies accepted");

            Console.Clear();

            driver.Navigate().GoToUrl("https://broker.unilogin.dk/auth/realms/broker/protocol/saml-stil?SAMLRequest=nZLBbsIwEER%2FJfI9cRIgEAuQaDkUiaoI0h56qTaOAYvETr1ORf%2B%2BToCWqhKHnizvet7OrDxGqMqazRq7V2vx3gi03rEqFbKuMSGNUUwDSmQKKoHMcraZPS5ZHISsNtpqrktyJbmtAERhrNSKeIv5hLz1BgmPBqmIIO4Xw2LbTyKeRtthfxQn%2BTbMixHwVKRpwon3Igw65YQ4kJMjNmKh0IKyrhTGsR8mfjTK4ogNYhb1Xok3d2mkAtup9tbWyCjNjT4IEzRKlnonVVAcKLj01AgoKzy36SUabTP5DuNCzi7m77XCphJmI8yH5OJ5vfzBgy0BW7r%2FjUdZ1aVoQbTSRVOKoN7XHZji6Yx94NhVAX1E7bvxx0%2Firc4u7qQqpNrd3m1%2BeoTsIctW%2Fuppk5HpuKWzbldm%2Bm%2BLlbBQgIU%2FDsf0mn%2B6%2Ff5M0y8%3D&RelayState=https%3A%2F%2Fatlas.uni-login.dk%2Funilogin%2Flogin.cgi%3Fid%3Dedulab%26path%3DaHR0cHM6Ly9sb2dpbi5tYXRlbWF0aWtmZXNzb3IuZGsvZXh0L3VuaWxvZ2luL2xvZ2luX2NhbGxiYWNrLz9yPWh0dHBzJTNBJTJGJTJGd3d3Lm1hdGVtYXRpa2Zlc3Nvci5kayUyRg%253D%253D%26auth%3D0a0212afeada128f9e719da9c10e879f&SigAlg=http%3A%2F%2Fwww.w3.org%2F2001%2F04%2Fxmldsig-more%23rsa-sha256&Signature=ESYbffCdeeC%2FJLfpZW1u2rzInLIw4%2BCDH%2F%2Ff55mZG9kAZsc0MpacteX2w4Fdm9OoRP2Tl5%2F%2BdC6zZnKFYqkz6RpPKGpCsqXPC9qhOgSKK%2FYKsWiNwbQY%2FTAT6XdNFVd5T%2FxEBQM9eD%2BFiiFsGOKpIao%2F%2FmEnydopSjWdJjUR%2BmmY7kKjGCVfPQ1GzXwGNtDWgCbepX2%2B2QebTBkUWVxbjLFzj4%2Boyex7cYEwmExa8h0%2BX6WGbVNeLBqJGZHTxlZqPmOa0N%2BSTKzDc1jBJLIps%2Bn8G3QvrVR%2F1tX6uiYpWw1ozneb1%2BTaSIXT9szcH2ZdRMKcPzE5vKcM1dWEywAnMQ%3D%3D");
            Thread.Sleep(500);
            driver.FindElement(By.XPath("/html/body/main/div/div/form/div[1]/input")).SendKeys(username); // puts the username
            Console.WriteLine("Filled username");
            driver.FindElement(By.XPath("/html/body/main/div/div/form/nav/button")).Click(); // clicks login 
            Thread.Sleep(250);
            driver.FindElement(By.XPath("/html/body/main/div/div/form/div[1]/input")).SendKeys(password); // puts the password
            Console.WriteLine("Filled Password");
            Thread.Sleep(120);
            driver.FindElement(By.XPath("/html/body/main/div/div/form/nav/div/div[1]/button")).Click(); // clicking loggin
            Console.WriteLine("Logged in");
            Thread.Sleep(4000);
            Console.Clear();

            while (true)
            {                       // https://www.matematikfessor.dk/test/trialexam/?id=5458&grade=false&history=true
                Console.Clear();
                driver.Navigate().GoToUrl("https://www.matematikfessor.dk/test/trialexam/?id=5458&grade=false&history=true");
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/p/span")).Click();
                Thread.Sleep(800);
                try
                {
                    driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/aside/ul/li[5]"));
                    Console.WriteLine("5");
                    spo = 5;
                }
                catch (Exception)
                {
                    naa = naa + 1;

                }

                if (spo == 100)
                {
                    try
                    {
                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/aside/ul/li[4]"));
                        spo = 4;
                    }
                    catch (Exception)
                    {
                        naa = naa + 1;
                    }

                }

                if (spo == 100)
                {
                    try
                    {
                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/aside/ul/li[3]"));
                        spo = 3;            // if there is 3 answers
                    }
                    catch (Exception)
                    {
                        spo = 2; // if 2 idk but i just added
                    }
                }

                Thread.Sleep(3000);

                Console.WriteLine("Gentager : " + spo + " Gange");
                Thread.Sleep(5000);
                int tid_tid = 0;
                var tid = Stopwatch.StartNew();
                try
                {
                    for (int i = 0; i < spo; i++)
                    {
                        Thread.Sleep(900);
                        Console.WriteLine("Opgave type: " + spo);
                        IWebElement tal1 = driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[2]/div/div/p[3]/span[2]/span/span/span[1]/span"));
                        num1 = Convert.ToInt32(tal1.Text);      // getting num 1 and converting it

                        IWebElement tal2 = driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[2]/div/div/p[3]/span[2]/span/span/span[5]/span"));
                        num2 = Convert.ToInt32(tal2.Text);      // getting num 2 and converting it

                        answer = num2 - num1;
                        string ans;
                        ans = Convert.ToString(answer);

                        tid.Stop();
                        Console.WriteLine("Tal 1 : " + num1);
                        Console.WriteLine("Tal 2 : " + num2);
                        Console.WriteLine("Answer = " + answer);
                        Console.WriteLine("Opgaver klarede (set): " + done);
                        Console.WriteLine("Opgaver klared i alt: " + doneopgave);
                        Console.WriteLine("Opgave klarede det tog: " + tid.ElapsedMilliseconds + " MS");

                        Thread.Sleep(1500);
                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/div/div[1]/div[3]/div/p/input")).SendKeys(ans);

                        driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/ul/li/button")).Click();

                        Thread.Sleep(3000);
                        Console.Clear();
                        int regn;
                        regn = Convert.ToInt32(tid.ElapsedMilliseconds);
                        tid_tid = regn + tid_tid;
                    }
                }catch (Exception)
                {
                    Console.WriteLine("Error");
                }

                spo = 100;
                Console.WriteLine("Opgave færdig det tog: " + tid_tid + " MS");


                driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/span/button")).Click();
                Thread.Sleep(1);
                driver.FindElement(By.XPath("/html/body/div[2]/main/div/article/div[2]/article/p/button[1]")).Click();

                done = done + 1;




            }
        }
        }
    }

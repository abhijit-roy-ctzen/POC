using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarchPractice.PageObject
{
  public class VideoPage
    {
        IWebDriver driver;
        public VideoPage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-browse[2]/div[3]/ytd-c4-tabbed-header-renderer/tp-yt-app-header-layout/div/tp-yt-app-header/div[2]/tp-yt-app-toolbar/div/div/tp-yt-paper-tabs/div/div/tp-yt-paper-tab[2]/div/div[1]")]
        public IWebElement VideoTab { get; set; }

         [FindsBy(How = How.XPath, Using = "/html/body/ytd-app/div[1]/ytd-page-manager/ytd-browse[2]/ytd-two-column-browse-results-renderer/div[1]/ytd-rich-grid-renderer/div[6]/ytd-rich-grid-row[1]/div/ytd-rich-item-renderer[1]/div/ytd-rich-grid-media/div[1]/div[2]/div[1]/h3/a/yt-formatted-string")]
        public IWebElement LatestVideo { get; set; }

        // public void NavigateTochannel()  
        public void getVideo()
        {
            //Thread.Sleep(3000);
            VideoTab.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            LatestVideo.Click();
            Thread.Sleep(10000);
           
        }
    }
}

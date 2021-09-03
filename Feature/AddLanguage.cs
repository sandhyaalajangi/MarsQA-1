using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddLanguageSteps
 
    {
        MarsQA_1.Pages.ProfileLanguagePage ProfileLanguagePageObj = new Pages.ProfileLanguagePage();

       [Given(@"seller enter language as ""(.*)""")]
        public void GivenSellerEnterLanguageAs(string Language)
        {
            ProfileLanguagePageObj.Language = Language;

        }
        [Given(@"select level as ""(.*)""")]
        public void GivenSelectLevelAs(string Level)
        {
            ProfileLanguagePageObj.Level = Level;
        }
        [When(@"clicks on Add action button")]
        public void WhenClicksOnAddActionButton()
        {
            ProfileLanguagePageObj.AddLanguage();
        }
        [Then(@"Language should be added to your profile\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenLanguageShouldBeAddedToYourProfile_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            //assert expected result = actual result
            Assert.AreEqual(message, ProfileLanguagePageObj.LanguageMessage);
        }

        [Given(@"seller updates language as ""(.*)""")]
        public void GivenSellerUpdatesLanguageAs(string Language)
        {
            ProfileLanguagePageObj.Language = Language;
        }

        [Given(@"updates level as ""(.*)""")]
        public void GivenUpdatesLevelAs(string Level)
        {
            ProfileLanguagePageObj.Level = Level;
        }

        [When(@"clicks on Update button")]
        public void WhenClicksOnUpdateButton()
        {
            ProfileLanguagePageObj.UpdateLanguage();
        }

        [Then(@"Language should be updated\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenLanguageShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            //assert expected result = actual result
            Assert.AreEqual(message, ProfileLanguagePageObj.LanguageMessage);
        }

        [When(@"Seller select to delete language ""(.*)""")]
        public void WhenSellerSelectToDeleteLanguage(string p0)
        {
            ProfileLanguagePageObj.DeleteLanguage();
        }

        [Then(@"Language should be deleted\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenLanguageShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string message)
        {
            //assert expected result = actual result
            Assert.AreEqual(message, ProfileLanguagePageObj.LanguageMessage);
        }





    }
}

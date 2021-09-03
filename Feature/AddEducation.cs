using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddProfileEducationStep
    {

        MarsQA_1.SpecflowPages.Pages.ProfileEducationPage ProfileEducationPageObj = new SpecflowPages.Pages.ProfileEducationPage();

       [Given(@"Seller enter UniversityName as ""(.*)""")]
        public void GivenSellerEnterUniversityNameAs(string p0)
        {
            ProfileEducationPageObj.UniversityName = p0;
        }

        [Given(@"Select CountryOfUniversity as ""(.*)""")]
        public void GivenSelectCountryOfUniversityAs(string country)
        {
            ProfileEducationPageObj.Country = country;
        }
        [Given(@"Select Title as ""(.*)""")]
        public void GivenSelectTitleAs(string title)
        {
            ProfileEducationPageObj.Title = title;
        }
        [Given(@"Enter Degree as ""(.*)""")]
        public void GivenEnterDegreeAs(string degree)
        {
            ProfileEducationPageObj.Degree = degree;
        }
        [Given(@"Select YearOfGreaduation as ""(.*)""")]
        public void GivenSelectYearOfGraduationAs(int p0)
        {
            ProfileEducationPageObj.YearOfGraduation = p0;
        }
        [When(@"Clicks on Add button on AddEducation page")]
        public void WhenClicksOnAddButtonOnAddEducationPage()
        {
            ProfileEducationPageObj.AddEducation();
        }
        [Then(@"Education should be added to the  profile\. The Alert message ""(.*)"" is displayed on top right of the application\.")]
        public void ThenEducationShouldBeAddedToTheProfile_TheAlertMessageIsDisplayedOnTopRightOfTheApplication_(string popupboxmessage)
        {
            Assert.AreEqual(popupboxmessage, ProfileEducationPageObj.EducationMessage);
        }




        [Given(@"seller updates education as ""(.*)""")]
        public void GivenSellerUpdatesEducationAs(string education)
        {
            ProfileEducationPageObj.UniversityName = education;
        }
        [Given(@"updates CountryOfUniversity as ""(.*)""")]
        public void GivenUpdatesCountryOfUniversityAs(string country)
        {

            ProfileEducationPageObj.Country = country;
        }
        [Given(@"updates Title as ""(.*)""")]
        public void GivenUpdatesTitleAs(string title)
        {
            ProfileEducationPageObj.Title = title;
        }
        [Given(@"updates Degree as ""(.*)""")]
        public void GivenUpdatesDegreeAs(string degree)
        {
            ProfileEducationPageObj.Degree = degree;
        }
        [Given(@"updates YearOfGreaduation as ""(.*)""")]
        public void GivenUpdatesYearOfGreaduationAs(int year)
        {
            ProfileEducationPageObj.YearOfGraduation = year;
        }
        [When(@"clicks on Update button on Updateeducation page")]
        public void WhenClicksOnUpdateButtonOnUpdateeducationPage()
        {
            ProfileEducationPageObj.UpdateEducation();
        }
        [Then(@"Education should be updated\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenEducationShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string popupboxmessage)
        {
            Assert.AreEqual(popupboxmessage, ProfileEducationPageObj.EducationMessage);
        }



        [When(@"Seller select to delete Educaion ""(.*)""")]
        public void WhenSellerSelectToDeleteEducaion(string p0)
        {
            ProfileEducationPageObj.DeleteEducation();
        }
        [Then(@"Education should be deleted\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenEducationShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string popupboxmessage)
        {
            Assert.AreEqual(popupboxmessage, ProfileEducationPageObj.EducationMessage);
        }

    }
}

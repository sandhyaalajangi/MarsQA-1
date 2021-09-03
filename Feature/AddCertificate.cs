using System;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddCertificationSteps
    {

        MarsQA_1.SpecflowPages.Pages.ProfileCertificationPage ProfileCertificationPageObj = new ProfileCertificationPage();


        [Given(@"Seller enter Certificate as ""(.*)""")]
        public void GivenSellerEnterCertificateAs(string Certificate)
        {
            ProfileCertificationPageObj.CertificateOrAward = Certificate;
        }
        [Given(@"Seller enter CertificateFrom as ""(.*)""")]
        public void GivenSellerEnterCertificateFromAs(string CertifiedFrom)
        {
            ProfileCertificationPageObj.CertifiedFrom = CertifiedFrom;
        }
        [Given(@"select Year as ""(.*)""")]
        public void GivenSelectYearAs(string p0)
        {
            ProfileCertificationPageObj.Year = p0;
        }
        [When(@"Clicks on Add button on Addcertification page")]
        public void WhenClicksOnAddButtonOnAddcertificationPage()
        {
            ProfileCertificationPageObj.AddCertification();
        }
        [Then(@"Certificate should be added to the  profile\. The Alert message ""(.*)"" is displayed on top right of the application\.")]
        public void ThenCertificateShouldBeAddedToTheProfile_TheAlertMessageIsDisplayedOnTopRightOfTheApplication_(string successorfailuremessage)
        {

            //assert expected result = actual result
            Assert.AreEqual(successorfailuremessage, ProfileCertificationPageObj.CertificationMessage);
        }
        [Given(@"seller Updates Certificate as ""(.*)""")]
        public void GivenSellerUpdatesCertificateAs(string Certificate)
        {
            ProfileCertificationPageObj.CertificateOrAward = Certificate;
        }
        [Given(@"updates Certificate From as ""(.*)""")]
        public void GivenUpdatesCertificateFromAs(string CertifiedFrom)
        {
            ProfileCertificationPageObj.CertifiedFrom = CertifiedFrom;
        }
        [Given(@"select Certificate Year as ""(.*)""")]
        public void GivenSelectCertificateYearAs(string CertificateYear)
        {
            ProfileCertificationPageObj.Year = CertificateYear;
        }
        [When(@"clicks on Update button on UpdateCertification page")]
        public void WhenClicksOnUpdateButtonOnUpdateCertificationPage()
        {
            ProfileCertificationPageObj.UpdateCertification();
        }
        [Then(@"certification should be updated\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenCertificationShouldBeUpdated_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string successorfailuremessage)
        {
            //assert expected result = actual result

            Assert.AreEqual(successorfailuremessage, ProfileCertificationPageObj.CertificationMessage);
        }

        [Given(@"seller delete the certificate")]
        public void GivenSellerDeleteTheCertificate()
        {
            // don''t do anything
        }

        [When(@"Seller select to delete Certification ""(.*)""")]
        public void WhenSellerSelectToDeleteCertification(string Certification)
        {
            ProfileCertificationPageObj.CertificateOrAward = Certification;
            ProfileCertificationPageObj.DeleteCertification();
        }
        [Then(@"Certification should be deleted\. The alert message, ""(.*)"" will be displayed on top right of the application\.")]
        public void ThenCertificationShouldBeDeleted_TheAlertMessageWillBeDisplayedOnTopRightOfTheApplication_(string successorfailuremessage)
        {
            //assert expected result = actual result
            Assert.AreEqual(successorfailuremessage, ProfileCertificationPageObj.CertificationMessage);

        }

    }
}

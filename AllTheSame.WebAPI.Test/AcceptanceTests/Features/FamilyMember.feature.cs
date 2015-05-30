﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AllTheSame.WebAPI.Test.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class FamilyMemberFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FamilyMember.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FamilyMember", "In order to see a list of familyMembers\r\nAs a Community Administrator\r\nI want to " +
                    "load a list of familyMembers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "FamilyMember")))
            {
                AllTheSame.WebAPI.Test.AcceptanceTests.Features.FamilyMemberFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add a familyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FamilyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FamilyMember")]
        public virtual void AddAFamilyMember()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add a familyMember", new string[] {
                        "FamilyMember"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Email",
                        "MobileNumber"});
            table1.AddRow(new string[] {
                        "Spec",
                        "Flow",
                        "x@y.com",
                        "800-555-1212"});
#line 9
 testRunner.Given("the following FamilyMember Add input", ((string)(null)), table1, "Given ");
#line 12
 testRunner.When("I call the add FamilyMember Post api endpoint to add a familyMember", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("the add result should be a FamilyMember Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Retrieve all familyMembers")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FamilyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FamilyMembers")]
        public virtual void RetrieveAllFamilyMembers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retrieve all familyMembers", new string[] {
                        "FamilyMembers"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.When("I call the FamilyMember Get api endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then("the get result should be a list of familyMembers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Retreive a familyMember by Id")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FamilyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FamilyMember")]
        public virtual void RetreiveAFamilyMemberById()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Retreive a familyMember by Id", new string[] {
                        "FamilyMember"});
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id"});
            table2.AddRow(new string[] {
                        "2"});
#line 25
 testRunner.Given("the following FamilyMember GetById input", ((string)(null)), table2, "Given ");
#line 28
 testRunner.When("I call the FamilyMember Get api endpoint by Id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the get by id result should be a FamilyMember", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Update a familyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FamilyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FamilyMember")]
        public virtual void UpdateAFamilyMember()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update a familyMember", new string[] {
                        "FamilyMember"});
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "FirstName",
                        "LastName",
                        "Email",
                        "MobileNumber"});
            table3.AddRow(new string[] {
                        "2",
                        "Spec",
                        "Flow",
                        "x@y.com",
                        "800-555-1212"});
#line 34
 testRunner.Given("the following FamilyMember Edit input", ((string)(null)), table3, "Given ");
#line 37
 testRunner.When("I call the edit FamilyMember Put api endpoint to edit a familyMember", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.Then("the edit result should be an updated FamilyMember", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete a familyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FamilyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FamilyMember")]
        public virtual void DeleteAFamilyMember()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete a familyMember", new string[] {
                        "FamilyMember"});
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id"});
            table4.AddRow(new string[] {
                        "0"});
#line 43
 testRunner.Given("the following FamilyMember Delete input", ((string)(null)), table4, "Given ");
#line 47
 testRunner.When("I call the delete FamilyMember Post api endpoint to delete a familyMember", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("the delete result should be an deleted FamilyMember", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check if a familyMember exists")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "FamilyMember")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FamilyMember")]
        public virtual void CheckIfAFamilyMemberExists()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if a familyMember exists", new string[] {
                        "FamilyMember"});
#line 52
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id"});
            table5.AddRow(new string[] {
                        "2"});
#line 53
 testRunner.Given("the following FamilyMember Id input", ((string)(null)), table5, "Given ");
#line 56
 testRunner.When("I call the FamilyMember Exists Get api endpoint by Id to verify if it exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.Then("the FamilyMember exists result should be bool true or false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
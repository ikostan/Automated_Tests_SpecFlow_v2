﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GameCore.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PlayerCharacterFeature : Xunit.IClassFixture<PlayerCharacterFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "PlayerCharacter.feature"
#line hidden
        
        public PlayerCharacterFeature(PlayerCharacterFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PlayerCharacter", "\tIn order to play the game\r\n\tAs a humat character\r\n\tI want my character health to" +
                    " be correctly represented", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Taking no damage when hit doesn\'t affect health")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Taking no damage when hit doesn\'t affect health")]
        public virtual void TakingNoDamageWhenHitDoesntAffectHealth()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Taking no damage when hit doesn\'t affect health", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I\'m a new _player", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("I take 0 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("My helth must remain 100", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PlayerCharacterFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PlayerCharacterFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

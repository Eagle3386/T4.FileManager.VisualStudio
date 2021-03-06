// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace T4.FileManager.VisualStudio.AcceptanceCriteria.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("UT013 Generate files without modifications", Description="\tAs a developer\r\n\tI can generate code with t4 and supress changes if the file exi" +
        "st", SourceFile="Features\\UT013_Generate_File_With_NoOverride_NoDelete.feature", SourceLine=0)]
    public partial class UT013GenerateFilesWithoutModificationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "UT013_Generate_File_With_NoOverride_NoDelete.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UT013 Generate files without modifications", "\tAs a developer\r\n\tI can generate code with t4 and supress changes if the file exi" +
                    "st", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line hidden
#line 6
 testRunner.Given("the file manager", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And("the script \"TestNoDelete.tt\" with following content for automation", @"<#@ template debug=""false"" hostspecific=""true"" language=""C#"" #>
<#@ assembly name=""System.Core"" #>
<#@ import namespace=""System.Linq"" #>
<#@ import namespace=""System.Text"" #>
<#@ import namespace=""System.Collections.Generic"" #>
<#@ output extension="".txt"" #>

<#@ include file=""$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude"" #>

<#
var fileManager = new T4FileManager(this.GenerationEnvironment, this.Host);
fileManager.CanOverwriteExistingFile = false;
fileManager.CreateNewFile(""TestNoDelete.g.cs"","""",""TestOverwrite"",null);	
#>
namespace Test
{
public class TestNoDelete
{
// first run template
}
}
<#
fileManager.Generate();
#>", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Generate files with CanOverwriteExistingFile is set to false, no files deleted", SourceLine=34)]
        public virtual void GenerateFilesWithCanOverwriteExistingFileIsSetToFalseNoFilesDeleted()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generate files with CanOverwriteExistingFile is set to false, no files deleted", null, ((string[])(null)));
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 36
 testRunner.Given("i run the script for automation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table13.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "TestOverwrite"});
#line 37
 testRunner.And("following files are generated:", ((string)(null)), table13, "And ");
#line hidden
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "From",
                            "To"});
                table14.AddRow(new string[] {
                            "fileManager.CreateNewFile(\"TestNoDelete.g.cs\",\"\",\"TestOverwrite\",null);",
                            "fileManager.CreateNewFile(\"TestNoDelete2.g.cs\",\"\",\"TestOverwrite\",null);"});
                table14.AddRow(new string[] {
                            "public class TestNoDelete",
                            "public class TestNoDelete2"});
#line 40
 testRunner.And("i change the line", ((string)(null)), table14, "And ");
#line hidden
#line 44
 testRunner.When("i run the script for automation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table15.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "TestOverwrite"});
                table15.AddRow(new string[] {
                            "TestNoDelete2.g.cs",
                            "TestOverwrite"});
#line 45
 testRunner.Then("following files are generated:", ((string)(null)), table15, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("No content changes if CanOverwriteExistingFile is set to false", SourceLine=49)]
        public virtual void NoContentChangesIfCanOverwriteExistingFileIsSetToFalse()
        {
            string[] tagsOfScenario = ((string[])(null));
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No content changes if CanOverwriteExistingFile is set to false", null, ((string[])(null)));
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 51
 testRunner.Given("i run the script for automation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Folder"});
                table16.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "TestOverwrite"});
#line 52
 testRunner.And("following files are generated:", ((string)(null)), table16, "And ");
#line hidden
                TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                            "From",
                            "To"});
                table17.AddRow(new string[] {
                            "// first run template",
                            "// second run template"});
#line 55
 testRunner.And("i change the line", ((string)(null)), table17, "And ");
#line hidden
#line 58
 testRunner.When("i run the script for automation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                            "File",
                            "Contains",
                            "Folder"});
                table18.AddRow(new string[] {
                            "TestNoDelete.g.cs",
                            "// first run template",
                            "TestOverwrite"});
#line 59
 testRunner.Then("following files are generated:", ((string)(null)), table18, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion

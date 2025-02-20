﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Kyiv.Tests
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class АріфметичніОпераціїFeature : object, Xunit.IClassFixture<АріфметичніОпераціїFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("uk"), "", "Аріфметичні операції", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "АрфіметичніОперації.feature"
#line hidden
        
        public АріфметичніОпераціїFeature(АріфметичніОпераціїFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }
        
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
        {
            await this.TestInitializeAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
        {
            await this.TestTearDownAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Додавання")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Додавання")]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0100\'", "\'00 0000 0000 0300\'", "\'00 0000 0000 0400\'", new string[0])]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0000\'", "\'17 7777 7777 7777\'", "\'17 7777 7777 7777\'", new string[0])]
        public async System.Threading.Tasks.Task Додавання(string доданок1, string доданок2, string сума, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("доданок1", доданок1);
            argumentsOfScenario.Add("доданок2", доданок2);
            argumentsOfScenario.Add("сума", сума);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Додавання", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 4
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 5
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", доданок1), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 6
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", доданок2), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 7
  await testRunner.AndAsync("ячейка 100 містить команду \'01 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 8
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 9
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 10
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", сума), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 11
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Віднімання")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Віднімання")]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0100\'", "\'00 0000 0000 0300\'", "\'20 0000 0000 0200\'", new string[0])]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0300\'", "\'00 0000 0000 0100\'", "\'00 0000 0000 0200\'", new string[0])]
        [Xunit.InlineDataAttribute("\'20 0000 0000 0015\'", "\'00 0000 0000 0013\'", "\'20 0000 0000 0030\'", new string[0])]
        public async System.Threading.Tasks.Task Віднімання(string зменшуване, string відємник, string різниця, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("зменшуване", зменшуване);
            argumentsOfScenario.Add("від\'ємник", відємник);
            argumentsOfScenario.Add("різниця", різниця);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Віднімання", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 19
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 20
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", зменшуване), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 21
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", відємник), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 22
  await testRunner.AndAsync("ячейка 100 містить команду \'02 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 23
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 24
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 25
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", різниця), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 26
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Віднімання модулей")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Віднімання модулей")]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0100\'", "\'00 0000 0000 0300\'", "\'20 0000 0000 0200\'", new string[0])]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0300\'", "\'00 0000 0000 0100\'", "\'00 0000 0000 0200\'", new string[0])]
        [Xunit.InlineDataAttribute("\'20 0000 0000 0015\'", "\'00 0000 0000 0013\'", "\'00 0000 0000 0002\'", new string[0])]
        [Xunit.InlineDataAttribute("\'20 0000 0000 0013\'", "\'00 0000 0000 0015\'", "\'20 0000 0000 0002\'", new string[0])]
        public async System.Threading.Tasks.Task ВідніманняМодулей(string зменшуване, string відємник, string різниця, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("зменшуване", зменшуване);
            argumentsOfScenario.Add("від\'ємник", відємник);
            argumentsOfScenario.Add("різниця", різниця);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Віднімання модулей", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 34
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 35
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 36
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", зменшуване), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 37
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", відємник), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 38
  await testRunner.AndAsync("ячейка 100 містить команду \'06 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 39
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 40
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 41
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", різниця), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 42
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Множення без скруглення")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Множення без скруглення")]
        [Xunit.InlineDataAttribute("\'00 0001 0000 0000\'", "\'00 0000 0020 0000\'", "\'00 0000 0000 0001\'", new string[0])]
        [Xunit.InlineDataAttribute("\'10 0000 0000 0000\'", "\'10 0000 0000 0000\'", "\'04 0000 0000 0000\'", new string[0])]
        [Xunit.InlineDataAttribute("\'04 0000 0000 0000\'", "\'04 0000 0000 0000\'", "\'01 0000 0000 0000\'", new string[0])]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0012\'", "\'00 0000 0001 0013\'", "\'00 0000 0000 0000\'", new string[0])]
        [Xunit.InlineDataAttribute("\'10 0000 0000 0000\'", "\'17 7777 7777 7777\'", "\'07 7777 7777 7777\'", new string[0])]
        public async System.Threading.Tasks.Task МноженняБезСкруглення(string множник1, string множник2, string добуток, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("множник1", множник1);
            argumentsOfScenario.Add("множник2", множник2);
            argumentsOfScenario.Add("добуток", добуток);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Множення без скруглення", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 52
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 53
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", множник1), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 54
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", множник2), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 55
  await testRunner.AndAsync("ячейка 100 містить команду \'10 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 56
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 57
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 58
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", добуток), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 59
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Множення із скругленням")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Множення із скругленням")]
        [Xunit.InlineDataAttribute("\'00 0001 0000 0000\'", "\'00 0000 0020 0000\'", "\'00 0000 0000 0001\'", new string[0])]
        [Xunit.InlineDataAttribute("\'10 0000 0000 0000\'", "\'10 0000 0000 0000\'", "\'04 0000 0000 0000\'", new string[0])]
        [Xunit.InlineDataAttribute("\'04 0000 0000 0000\'", "\'04 0000 0000 0000\'", "\'01 0000 0000 0000\'", new string[0])]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0012\'", "\'00 0000 0001 0013\'", "\'00 0000 0000 0000\'", new string[0])]
        public async System.Threading.Tasks.Task МноженняІзСкругленням(string множник1, string множник2, string добуток, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("множник1", множник1);
            argumentsOfScenario.Add("множник2", множник2);
            argumentsOfScenario.Add("добуток", добуток);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Множення із скругленням", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 70
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 71
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 72
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", множник1), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 73
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", множник2), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 74
  await testRunner.AndAsync("ячейка 100 містить команду \'11 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 75
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 76
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 77
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", добуток), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 78
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Ділення")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Ділення")]
        [Xunit.InlineDataAttribute("\'04 0000 0000 0000\'", "\'10 0000 0000 0000\'", "\'10 0000 0000 0000\'", new string[0])]
        [Xunit.InlineDataAttribute("\'17 7777 7777 7777\'", "\'17 7777 7777 7777\'", "\'17 7777 7777 7777\'", new string[0])]
        [Xunit.InlineDataAttribute("\'17 2777 7777 7777\'", "\'17 2777 7777 7777\'", "\'17 7777 7777 7777\'", new string[0])]
        public async System.Threading.Tasks.Task Ділення(string ділене, string дільник, string частка, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ділене", ділене);
            argumentsOfScenario.Add("дільник", дільник);
            argumentsOfScenario.Add("частка", частка);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Ділення", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 89
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 90
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 91
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", ділене), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 92
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", дільник), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 93
  await testRunner.AndAsync("ячейка 100 містить команду \'12 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 94
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 95
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 96
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", частка), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 97
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Додавання команд")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Додавання команд")]
        [Xunit.InlineDataAttribute("\'12 5252 5252 5252\'", "\'25 2525 2525 2525\'", "\'37 7777 7777 7777\'", new string[0])]
        [Xunit.InlineDataAttribute("\'00 0000 0000 0000\'", "\'02 5252 5252 5252\'", "\'02 5252 5252 5252\'", new string[0])]
        public async System.Threading.Tasks.Task ДодаванняКоманд(string ділене, string дільник, string частка, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ділене", ділене);
            argumentsOfScenario.Add("дільник", дільник);
            argumentsOfScenario.Add("частка", частка);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Додавання команд", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 105
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 106
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 107
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", ділене), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 108
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", дільник), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 109
  await testRunner.AndAsync("ячейка 100 містить команду \'03 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 110
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 111
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 112
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", частка), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 113
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Циклічне додавання")]
        [Xunit.TraitAttribute("FeatureTitle", "Аріфметичні операції")]
        [Xunit.TraitAttribute("Description", "Циклічне додавання")]
        [Xunit.InlineDataAttribute("\'17 3675 7367 5712\'", "\'17 3675 7367 5712\'", "\'16 7573 6757 3624\'", new string[0])]
        public async System.Threading.Tasks.Task ЦиклічнеДодавання(string ділене, string дільник, string частка, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ділене", ділене);
            argumentsOfScenario.Add("дільник", дільник);
            argumentsOfScenario.Add("частка", частка);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Циклічне додавання", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 120
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 121
  await testRunner.GivenAsync("пам\'ять заповнена значенями 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Дано ");
#line hidden
#line 122
  await testRunner.AndAsync(string.Format("ячейка 5 містить команду {0}", ділене), ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 123
  await testRunner.AndAsync(string.Format("ячейка 18 містить команду {0}", дільник), ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
#line 124
  await testRunner.AndAsync("ячейка 100 містить команду \'07 0005 0022 0002\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 125
  await testRunner.AndAsync("регістр лічільник команд містить 100", ((string)(null)), ((global::Reqnroll.Table)(null)), "І ");
#line hidden
#line 126
  await testRunner.WhenAsync("виконати команді", ((string)(null)), ((global::Reqnroll.Table)(null)), "Якщо ");
#line hidden
#line 127
  await testRunner.ThenAsync(string.Format("ячейка 2 містить команду {0}", частка), ((string)(null)), ((global::Reqnroll.Table)(null)), "Тоді ");
#line hidden
#line 128
  await testRunner.AndAsync("лічільник команд містить 101", ((string)(null)), ((global::Reqnroll.Table)(null)), "А також ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : object, Xunit.IAsyncLifetime
        {
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
            {
                await АріфметичніОпераціїFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await АріфметичніОпераціїFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Gherkin.CucumberMessages.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips2.Support
{
    [Binding]
    class Reportgenerator
    {
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentReports feature;
        AventStack.ExtentReports.ExtentTest scenario,step;
        static string reportpath = System.IO.Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + "Result" + Path.DirectorySeparatorChar + "Result_"
            + DateTime.Now.ToString("ddmmyyy hhmmss");

        [BeforeTestRun]

        public static void BeforeTestRun()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [BeforeFeature]

        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            scenario = feature.CreateNode(context.ScenarioInfo.Title); 
        }

        [BeforeStep]

        public void BeforeStep()
        {
            step = scenario;
        }
        [AfterStep]

        public void AfterStep(ScenarioContext context)            
        {
            if(context.TestError == null)
            {
                step.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if(context.TestError != null)
            {
                step.Log(Status.Fail, context.StepContext.StepInfo.Text);
            }

        }
        [AfterFeature]

        public static void AfterFeature()
        {
            extent.Flush();
        }        
  
    }

}
  


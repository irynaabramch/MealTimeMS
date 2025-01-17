using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealTimeMS.ExclusionProfiles;

namespace MealTimeMS.Util
{
    public class GlobalVar
    {
		//Program Info
		public const String programVersion = "1.0";
		public const String programName = "MealTimeMS";
		
		//Pre-experiment setup directions
        public static bool IsSimulation = true;
		public static bool useRTCalcComputedFile = false;
	    public static bool useChainsawComputedFile = false;
		public static bool useIDXComputedFile = false;
		public static bool useDecoyFastaComputedFile = false;
		public static bool usePepXMLComputedFile = false;
		public static bool useLogisticRegressionTrainedFile = false;
		public static bool useMeasuredRT = false;

		public static bool isSimulationForFeatureExtraction = false;

		public static double amountPerturbationAroundMeasuredRetentionTimeInSeconds = 0.0;


		//scan info table header -- do NOT change these values
		public const String MSLevelHeader = "MSOrder";
        public const String PrecursorChargeHeader = "Charge State:";
        public const String PrecursorMZHeader = "Monoisotopic M/Z:";
        public const String ScanNumHeader = "Scan";
        public const String ScanTimeHeader= "StartTime";

		//modification
		//public static double AminoAcid_M_modifiedMass = 15.9949;

		//Experiment Params
		//public static int SimulationSampleNumber = 5000;
		public static int ScansPerOutput = 100;
        public static bool SeeExclusionFormat = false;
        public static bool SetExclusionTable = false;
        public static int NUM_MISSED_CLEAVAGES = 1;
        public static double ppmTolerance = 5.0/1000000.0;
        public static double retentionTimeWindowSize = 0.75;
        public static int MinimumPeptideLength = 6;
		public static String DecoyPrefix = "DECOY_";
		public static String DBTargetProteinStartString = "sp|";
		//public static double LRModelDecisionThreshold = 0.70;
		public static double AccordThreshold = 0.70;
		//Nora Parameters
		public static double XCorr_Threshold = 2.5;
		public static int NumDBThreshold = 2;
		//runtime var
		public static double acquisitionStartTime = -1;
        public static double listeningDuration = 60000000; //in seconds
        public static String experimentName = "experiment_name";
		public static ExclusionProfileEnum ExclusionMethod; //Synonomous with "ExclusionType"


		//Simulation var
		public static double ExperimentTotalScans = -1;



		//temp variables
		public static int randomRepeatsPerExperiment =10;
		//ExclusionExplorerParamsList
		public static List<double> PPM_TOLERANCE_LIST;
		public static List<double> RETENTION_TIME_WINDOW_LIST;

		public static List<double> LR_PROBABILITY_THRESHOLD_LIST;

		public static List<double> XCORR_THRESHOLD_LIST;
		public static List<int> NUM_DB_THRESHOLD_LIST;


    }
}

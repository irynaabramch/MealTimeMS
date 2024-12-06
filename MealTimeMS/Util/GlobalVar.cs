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
        public static bool IsSimulation = true;         //is this a simulation or if we're actually connecting this to a mass spec

		public static bool isSimulationForFeatureExtraction = false;
		public static bool isForBrukerRunTime = false;

		public static double amountPerturbationAroundMeasuredRetentionTimeInSeconds = 0.0;


		//scan info table header for the Thermo API -- do NOT change these values
		public const String MSLevelHeader = "MSOrder";
        public const String PrecursorChargeHeader = "Charge State:";
        public const String PrecursorMZHeader = "Monoisotopic M/Z:";
        public const String ScanNumHeader = "Scan";
        public const String ScanTimeHeader= "StartTime";

		//modification
		//public static double AminoAcid_M_modifiedMass = 15.9949;

		//Experiment Params

        public static int NUM_MISSED_CLEAVAGES = 2;
        public static int MinimumPeptideLength = 6;
		public static String DecoyPrefix = "DECOY_";
		public static String DBTargetProteinStartString = "sp|";
		public static double AccordThreshold = 0.70; // Probability threshold for the logistic regression classifier
        //Exclusion tolerance parameters
        public static double ppmTolerance = 5.0/1000000.0;
        public static double retentionTimeWindowSize = 1.0;
        public static double IMWindowSize = 0.03;

		//Heuristic Exclusion Parameters
		public static double XCorr_Threshold = 2.5;
		public static int NumDBThreshold = 2;
		//runtime var
		public static double acquisitionStartTime = -1;
        public static double listeningDuration = 60000000; //in seconds
        public static String experimentName = "experiment_name";
		public static ExclusionProfileEnum ExclusionMethod; //Synonomous with "ExclusionType"
		public static int ExperimentTotalScans;

		public static int ddaNum = 100;
        public static bool includeIonMobility = true;
        //Simulation var
        public static double ExperimentTotalMS2 = -1;

        //Connection var
        public static String kafka_url = "localhost:9092";
        public static String schemaRegistry_url = "http://localhost:8083";
        public static String exclusionMS_url = "http://192.168.0.29:8000"; // url of the exclusionMS webserver (url+ port number)
        public static String exclusionMS_ip = "http://192.168.0.29"; // ip of the exclusionMS webserver
        public static int exclusionMS_max_number_of_intervals_per_POST_request = 100; //Patrick said ExclusionMS would rather have more requests with smaller number of intervals than a single request with too many interval. Sending more than 100 may create lag spike during acquisition. 

        //temp variables
        public static int randomRepeatsPerExperiment = 3;
        public static Dictionary<int, int> TIMSTOF_Precursor_ID_to_ms2_id = null;
        public static Dictionary<int, double> CheatingMonoPrecursorMassTable = null;
        //ExclusionExplorerParamsList
        public static List<double> PPM_TOLERANCE_LIST;
		public static List<double> RETENTION_TIME_WINDOW_LIST;
		public static List<double> ION_MOBILITY_WINDOW_LIST;

		public static List<double> LR_PROBABILITY_THRESHOLD_LIST;

		public static List<double> XCORR_THRESHOLD_LIST;
		public static List<int> NUM_DB_THRESHOLD_LIST;

        //Debugging
        public static int ScansPerOutput = 500;
        public static int verbosity = 0;
        public static bool ClearExclusionListBeforeEachRun = true;
        public static int DebugIntervals = 0; //0 = nothing; 1= 2 min intervals; 2 = 10 min intervals
        

    }
}

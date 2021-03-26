﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MealTimeMS.Data;
using MealTimeMS.Util;
using MealTimeMS.Data.Graph;
using MealTimeMS.ExclusionProfiles;

namespace MealTimeMS.Tester
{
	public static class ExtractNumberOfPeptidePerIdentifiedProtein
	{
		public static String DoJob(ProteinProphetResult ppr, ExclusionProfile exclusionProfile, int experimentNum)
		{
			String outputFolder = Path.Combine(InputFileOrganizer.OutputFolderOfTheRun, "PedtideCountAndSpectralCountPerProtein");
			if (!Directory.Exists(outputFolder))
			{
				Directory.CreateDirectory(outputFolder);
			}
			String outputFile = Path.Combine(outputFolder,  "NumberOfPeptidesPerIdentifiedProtein_"+ experimentNum + ".txt");
			StreamWriter sw = new StreamWriter(outputFile);
			sw.WriteLine("Accession\tNumberOfPeptides\tSpectralCount");

			//List<String> confidentlyIdentifiedProts =  ppr.getProteinsIdentified();
            List<String> AllProteins = exclusionProfile.getDatabase().getProteinSet();

			foreach(String accession in AllProteins)
			{
				Protein prot = exclusionProfile.getDatabase().getProtein(accession);
				HashSet<String> peptidesObserved = new HashSet<String>();
				foreach(PeptideScore pepEvidence in prot.getPeptideScore())
				{
					peptidesObserved.Add(pepEvidence.getPeptideSequence());
				}
				sw.WriteLine("{0}\t{1}\t{2}", accession, peptidesObserved.Count,prot.getPeptideScore().Count);
			}

			sw.Close();
			return outputFile;

		}
	}
}

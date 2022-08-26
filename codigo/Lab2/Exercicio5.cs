using System;

class SemVogal {

	
	static string RemoveVogal(string frase, int i) {
	
		string vogal = "aeiouAEIOU";
		
		for(int j = 0; j<frase.Length; j++) {
			if (frase[i]==vogal[j]) {
				frase = frase.Replace(frase[i], ' ');						
			}
		}

		if (i==frase.Length-1)
			return ""+frase[i];
		else return frase[i]+RemoveVogal(frase, ++i);
	}

	
	static void Main(string[] args) {
		
		string frase;
		
		if (args.Length>0)
			frase = args[0];
		else {
			Console.Write("Informe frase: ");
			frase = Console.ReadLine();
		}
		Console.WriteLine(RemoveVogal(frase, 0));
	}
}

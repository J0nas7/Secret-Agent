using System;
using System.Collections;

namespace SecretAgent
{
    public class Agent
    {
        // class variables
        public static int agentCounter = 1;

        // instance variables
        private int id;
        private string name;
        private ArrayList languages = new ArrayList();

        public Agent(string name, string[] languages)
        {
            this.id = agentCounter;
            this.name = name;
            this.languages.Add("");
            this.languages.Add("");

            this.CodeName = CeasarEncryption.Encrypt(name, 12);
            this.setLanguages(languages[0], languages[1]);

            agentCounter++;
        }

        // property for name
        public void setName(string Name) {
            this.name = Name;
            this.CodeName = CeasarEncryption.Encrypt(Name, 12);
        }
        public string getName() {
            return this.name;
        }

        public string CodeName { get; set; }

        public string getId() {
            string theId = "00" + this.id;
            return theId.Substring(theId.Length - 3, 3);
        }

        public void setLanguages(string language1,  string language2)
        {
            this.languages[0] = language1;
            this.languages[1] = language2;
        }

        public ArrayList getLanguages() {
            return this.languages;
        }

        // ToString
        public override string ToString()
        {
            string result = "This agent's name is " + this.name + " with ID " + this.id + ", codename " + this.CodeName + ".";
            if (this.languages.Count == 2)
            {
                result += "Speaks two languages: " + this.languages[0] + " and " + this.languages[1];
            }
            return result;
        }
    }
}

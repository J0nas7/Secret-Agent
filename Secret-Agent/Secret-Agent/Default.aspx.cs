using System;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecretAgent
{

    public partial class Default : System.Web.UI.Page
    {
        static ArrayList agentList;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                agentList = new ArrayList();
                string[] langs1 = { "DA", "UA" };
                string[] langs2 = { "SE", "EN" };
                string[] langs3 = { "NO", "RU" };
                agentList.Add(new Agent("Bond", langs1));
                agentList.Add(new Agent("Bill", langs2));
                agentList.Add(new Agent("Bjarnil", langs3));
                this.listboxagentUpdate();
            }
        }

        protected void createAgent(object sender, EventArgs args)
        {
            string agentName = TextBoxName.Text;
            string lang1 = TextBoxLang1.Text;
            string lang2 = TextBoxLang2.Text;
            string[] langs = {lang1, lang2};
            agentList.Add(new Agent(agentName, langs));
            TextBoxName.Text = "";
            TextBoxLang1.Text = "";
            TextBoxLang2.Text = "";
            this.listboxagentUpdate();
        }

        protected void showAgents(object sender, EventArgs e)
        {
            this.listboxagentUpdate();
        }

        protected void handleAgent(object sender, EventArgs e)
        {
            string agentInfo = ListBoxAgents.SelectedItem.ToString();
            if (agentInfo != "")
            {
                Agent editAgent;
                for (int i = 0; i < agentList.Count; i++)
                {
                    Agent theAgent = (Agent)agentList[i];
                    string tempAgentInfo = "Agent " + theAgent.CodeName + ", ID: " + theAgent.getId();
                    if (agentInfo == tempAgentInfo)
                    {
                        editAgent = theAgent;
                        EditName.Text = editAgent.getName();
                        EditLang1.Text = (string)editAgent.getLanguages()[0];
                        EditLang2.Text = (string)editAgent.getLanguages()[1];
                        HandleAgent.Text = agentInfo;
                    }
                }
            }
        }

        protected void updateAgent(object sender, EventArgs e)
        {
            string agentInfo = HandleAgent.Text;
            for (int i = 0; i < agentList.Count; i++)
            {
                Agent theAgent = (Agent)agentList[i];
                string tempAgentInfo = "Agent " + theAgent.CodeName + ", ID: " + theAgent.getId();
                if (agentInfo == tempAgentInfo)
                {
                    theAgent.setLanguages(EditLang1.Text, EditLang2.Text);
                    theAgent.setName(EditName.Text);
                    if (EditCeasarText.Text != "" && EditCeasarKey.Text != "")
                    {
                        theAgent.CodeName = CeasarEncryption.Encrypt(EditCeasarText.Text, Int32.Parse(EditCeasarKey.Text));
                    }

                    agentList[i] = theAgent;
                    EditName.Text = "Real name";
                    EditLang1.Text = "Native Lang";
                    EditLang2.Text = "Other Lang";
                    EditCeasarText.Text = "";
                    EditCeasarKey.Text = "";
                    HandleAgent.Text = "Choose an Agent";
                    this.listboxagentUpdate();
                }
            }
        }

        public void listboxagentUpdate()
        {
            ListBoxAgents.Items.Clear();
            string noOfAgents = "00" + agentList.Count;
            LabelNo_Agents.Text = "Number of Secret Agents: " + noOfAgents.Substring(noOfAgents.Length-3, 3);
            for (int i = 0; i < agentList.Count; i++)
            {
                Agent theAgent = (Agent) agentList[i];
                ListBoxAgents.Items.Add("Agent "+ theAgent.CodeName +", ID: "+theAgent.getId());
            }
        }
    }
}

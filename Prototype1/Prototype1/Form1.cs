using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
/*
 * News Reader version 1
 * Release Notes
 * 
 * This program is an RSS Feed news reader that allows you to enter in search terms and see what liberal and conservatives say about that topic. 
 * 
 * Known issues 
 * - Dull and boring User Interface
 * - Need to rework system so as to remove the no title found, no description found, no link found if all three of those are true
 * 
 * Comments will be extensive
 */
namespace Prototype1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Declaring variables to use
         * - liberalRss is a multidimensional string variable that holds the rss data from liberal news sites
         * - conservativeRss is a multidimensional string variable that holds the rss data from conservative news sites
         * - liberal is an array list variable that will hold all of the rss feed addresses for liberals
         * - conservative is an array list variable that will hold all of the rss feed addresses for conservatives
         * - channel is a variable that converts an arraylist value from either liberal or conservative arrays into a string for easier reading
         * 
         */
        String[,] liberalRss = null;
        String[,] conservativeRss = null;
        ArrayList liberal = new ArrayList();
        ArrayList conservative = new ArrayList();
        String channel;

        /*
         * the getRssData Method pseudo code 
         * 
         * - accepts two arguments
         *      o an array list of addresses
         *      o search terms in a string
         * - creates several variables that are bound by one purpose to create data that is distinct 
         *      o this goes in with the search functionality
         * - begins a for loop that starts at 0 and goes until it is greater than the address array list variable
         * - it does the following 
         *      o takes an address from the array list
         *      o connects to that address 
         *      o gathers rss data from that address and stores it in rssItems 
         *          - this will be so that we can search through it easier
         *      o creates three variables that will select the nodes that begin with title, description, and link
         *      o creates two variables for search term functionality
         *      o creates another for loop that starts at 0 and goes through the length of the primaryArray
         *      o the for loop does the following
         *          - it checks to see if the inner text of the title node and description node is not null and has the search term in it
         *          - if yes to both add to the final array that will be returned and end loop 
         *          - if not simply put in blank values for all
         *         
         */
        private String[,] getRssData(ArrayList list, string searchTerm)
        {
            String[,] tempRssData = new String[1000, 3];
            String[,] distinctRssData = new String[1000, 3];
            String[] searchArray = searchTerm.Split(' ');
            String[] primaryArray = searchArray.Distinct().ToArray();

            for (int h = 0; h < list.Count; h++)
            {
                channel = Convert.ToString(list[h]);
                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
                System.Net.WebResponse myResponse = myRequest.GetResponse();
                System.IO.Stream rssStream = myResponse.GetResponseStream();
                System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();
                rssDoc.Load(rssStream);
                System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

                for (int i = 0; i < rssItems.Count; i++)
                {

                    System.Xml.XmlNode titleNode;
                    System.Xml.XmlNode descrNode;
                    System.Xml.XmlNode linkNode;
                    int titleInt;
                    int descrInt;

                    titleNode = rssItems.Item(i).SelectSingleNode("title");
                    descrNode = rssItems.Item(i).SelectSingleNode("description");
                    linkNode = rssItems.Item(i).SelectSingleNode("link");

                    for (int j = 0; j < primaryArray.Length; j++)
                    {
                        titleInt = titleNode.InnerText.IndexOf(primaryArray[j]);
                        descrInt = descrNode.InnerText.IndexOf(primaryArray[j]);
                        if ((titleNode != null && titleInt > 0) || (descrNode != null && descrInt > 0))
                        {
                            tempRssData[i, 0] = titleNode.InnerText;
                            tempRssData[i, 1] = descrNode.InnerText;
                            tempRssData[i, 2] = linkNode.InnerText;
                            j = primaryArray.Length;
                        }
                        //else
                        //{
                        //    tempRssData[i, 0] = "No Title Found";
                        //    tempRssData[i, 1] = "No Description Given";
                        //    tempRssData[i, 2] = "No Link Available";
                        //}
                    }

                }
            }

            return tempRssData;
        }

        /*
         * These list box events help to find the position of the news title and use that information 
         * to call up the link and description information. 
         */
        private void liberalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (liberalRss[liberalListBox.SelectedIndex, 1] != null)
                liberalDescriptionBox.Text = liberalRss[liberalListBox.SelectedIndex, 1];
            if (liberalRss[liberalListBox.SelectedIndex, 2] != null)
                liberalLinkLabel.Text = "Go To: " + liberalRss[liberalListBox.SelectedIndex, 2];
        }

        private void conservativeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conservativeRss[conservativeListBox.SelectedIndex, 1] != null)
                conservativeDescriptionBox.Text = conservativeRss[conservativeListBox.SelectedIndex, 1];
            if (conservativeRss[conservativeListBox.SelectedIndex, 2] != null)
                conservativeLinkLabel.Text = "Go To: " + conservativeRss[conservativeListBox.SelectedIndex, 2];
        }

        /*
         * The startButton click event does the following
         * - captures whats in the search text box and converts it into a string
         * - activates the getRssData method using the liberal, conservative, and searchterm
         * - creates a for loop which does the following
         *      o checks to see if the rss data is not null and then puts it in the list box
         */
        private void startButton_Click(object sender, EventArgs e)
        {
            //checking to see if the liberalRSS and conservativeRSS arrays are not null
            //If they are not null then empty them 

            if (liberalRss != null && conservativeRss != null)
            {
                liberalListBox.Items.Clear();
                conservativeListBox.Items.Clear();
                Array.Clear(liberalRss, 0, liberalRss.Length);
                Array.Clear(conservativeRss, 0, conservativeRss.Length);
                liberalDescriptionBox.Text = "";
                conservativeDescriptionBox.Text = "";
            }

            string searchTerm = searchTextBox.Text;
            liberalRss = getRssData(liberal, searchTerm);
            for (int i = 0; i < liberalRss.GetLength(0); i++)
            {
                if (liberalRss[i, 0] != null)
                {
                    liberalListBox.Items.Add(liberalRss[i, 0]);
                }
            }
            conservativeRss = getRssData(conservative, searchTerm);
            for (int i = 0; i < conservativeRss.GetLength(0); i++)
            {
                if (conservativeRss[i, 0] != null)
                {
                    conservativeListBox.Items.Add(conservativeRss[i, 0]);
                }
            }
        }

        /*
         * This form load event reads the addresses in the conservative and liberal text files
         * Then places those addresses in a simple array list that will be used with the getRssData method
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("liberal.txt"))
            {
                String address;

                while ((address = sr.ReadLine()) != null)
                {
                    liberal.Add(address);
                }
            }
            using (StreamReader sr = new StreamReader("conservative.txt"))
            {
                String address;

                while ((address = sr.ReadLine()) != null)
                {
                    conservative.Add(address);
                }
            }
        }

        private void destinationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (liberalRss[liberalListBox.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(liberalRss[liberalListBox.SelectedIndex, 2]);
        }

        private void conservativeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (conservativeRss[conservativeListBox.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(conservativeRss[conservativeListBox.SelectedIndex, 2]);
        }
    }
}

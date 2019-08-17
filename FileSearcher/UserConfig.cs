using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;


namespace FileSearcher
{
    public class UserConfigData
    {
        //Variables
        private String m_searchDir = "C:\\";
        private String m_fileName = "*.txt";
        private String m_containingText = "";

        //Public Properties
        public String SearchDir
        {
            get { return m_searchDir; }
            set { m_searchDir = value; }
        }

        public String FileName
        {
            get { return m_fileName; }
            set { m_fileName = value; }
        }

        public String ContainingText
        {
            get { return m_containingText; }
            set { m_containingText = value; }
        }
    }

    public class UserConfig
    {
        //Variables
        private static UserConfigData m_configData = new UserConfigData();

        //Public Properties

        public static UserConfigData Data
        {
            get { return m_configData; }
        }
    }
}

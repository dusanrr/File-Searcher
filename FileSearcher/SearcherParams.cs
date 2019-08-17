using System;
using System.Text;
using System.Collections.Generic;


namespace FileSearcher
{
    public class SearcherParams
    {
        //Variables

        private String m_searchDir;
        private List<String> m_fileNames;
        private String m_containingText;
        private Encoding m_encoding;

        //Constructor

        public SearcherParams(  String searchDir,
                                List<String> fileNames,
                                String containingText,
                                Encoding encoding)
        {
            m_searchDir = searchDir;
            m_fileNames = fileNames;
            m_containingText = containingText;
            m_encoding = encoding;
        }

        //Public Properties

        public String SearchDir
        {
            get { return m_searchDir; }
        }

        public List<String> FileNames
        {
            get { return m_fileNames; }
        }

        public String ContainingText
        {
            get { return m_containingText; }
        }

        public Encoding Encoding
        {
            get { return m_encoding; }
        }
    }
}

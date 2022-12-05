using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget {
    class PCFGHelper {
        private string path;

        public PCFGHelper() {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\.pcfg";
        }

        public string AppPath {
            get {
                if (File.Exists(path)) {
                    string[] content = File.ReadAllLines(path);

                    for (int i = 0; i < content.Length; i++) {
                        if (content[i].Equals("[Budget]"))
                            return content[i + 1];
                        else
                            return "";
                    }

                    return "";

                } else return "";
            }
        }
    }
}

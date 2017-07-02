namespace AplikasiKonterHP
{
    using System;
    using System.Windows.Forms;


    public static class Helpers
    {
        #region Declaration
        public static ErrorProvider myError = new ErrorProvider();
        #endregion

        #region Security Methods
        #endregion

        #region Error Provider
        public static bool GetValidate(Control myContainer)
        {
            bool myResult = true;
            foreach(Control CTRL in myContainer.Controls)
            {
                // error checking code :
                // 0. eror provider title for error message
                // 1. empty value (text for textbox, combobox. and any checked item for checkbox)
                // 2. text value format. [0] = not checked, [1], cant be zero, [2] cant be negative, [3] cant be positive, [4] phone format, [5] email format	
                // 3. date check. [0] not checked, [1] cant be same as today, [2] cant be smaller than today, [3] cant be greater than today
                // 1;Nama Login,1,0-,0- 

                // 1
                //Nama Login,1,0-,0- 

                //Nama Login
                //1
                //1-5
                //0-
                if(CTRL.Tag != null)
                {
                    myError.SetIconAlignment(CTRL, ErrorIconAlignment.MiddleRight);
                    myError.SetIconPadding(CTRL, 2);
                    myError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    myError.SetError(CTRL, string.Empty);

                    string[] TagString = CTRL.Tag.ToString().Split(Convert.ToChar(";"));
                    string[] TagCode = TagString[1].ToString().Split(Convert.ToChar(","));
                    string[] TextCode = TagCode[2].ToString().Split(Convert.ToChar("-"));
                    string[] DateCode = TagCode[3].ToString().Split(Convert.ToChar("-"));

                    switch(CTRL.GetType().Name.ToString())
                    {
                        case ("TextBox"):
                            if(TagCode[1] == "1" && string.IsNullOrEmpty((CTRL as TextBox).Text))
                            {
                                myError.SetError(CTRL, TagCode[0] + " tidak boleh kosong");
                                myResult = false;
                            }

                            int n;
                            if (Convert.ToInt32(TextCode[0]) > 0 && int.TryParse((CTRL as TextBox).Text, out n) == false)
                            {
                                myError.SetError(CTRL, TagCode[0] + " harus berisi numerik");
                                myResult = false;
                                break;
                            }
                            else
                            {
                                for (int i = 1; i < TextCode.Length; i++)
                                {
                                    switch (TextCode[i])
                                    {
                                        case ("1"):
                                            if ((CTRL as TextBox).Text == "0")
                                            {
                                                myError.SetError(CTRL, TagCode[0] + " tidak boleh berisi 0");
                                                myResult = false;
                                            }
                                            break;

                                        case ("2"):
                                            if (Convert.ToInt32((CTRL as TextBox).Text) < 0)
                                            {
                                                myError.SetError(CTRL, TagCode[0] + " tidak boleh negatif");
                                                myResult = false;
                                            }
                                            break;

                                        case ("3"):
                                            if (Convert.ToInt32((CTRL as TextBox).Text) > 0)
                                            {
                                                myError.SetError(CTRL, TagCode[0] + " tidak boleh positif");
                                                myResult = false;
                                            }
                                            break;
                                        case ("4"):
                                            // check phone format with regex
                                            //										if (Convert.ToInt32((CTRL as TextBox).Text) < 0)
                                            //										{
                                            //											MyError.SetError(CTRL, TagCode[0] + " tidak angka negatif");
                                            //											MyResult = false;
                                            //										}
                                            break;
                                        case ("5"):
                                            // check email format with regex
                                            //										if (Convert.ToInt32((CTRL as TextBox).Text) < 0)
                                            //										{
                                            //											MyError.SetError(CTRL, TagCode[0] + " tidak angka negatif");
                                            //											MyResult = false;
                                            //										}
                                            break;
                                    }
                                }
                            }
                            break;

                        case ("CheckedListBox"):
                            if (TagCode[1] == "1" && (CTRL as CheckedListBox).SelectedItems.Count < 1)
                            {
                                myError.SetError(CTRL, TagCode[0] + " harus dipilih salah satu");
                                myResult = false;
                            }
                            break;
                    }
                }
            }
            return myResult;
        }

        #endregion

        #region Generated Data Method
        public static int GetNewID(string myTableName, string myFieldName)
        {
            int myID;
            myID = Convert.ToInt32(DataAccess.GetSingleValue("select count(" + myFieldName + ") From " + myTableName));
            return myID + 1;
        }
        #endregion

        #region MessageBox
        public static void MsgBoxSave()
        {
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgBoxUpdate()
        {
            MessageBox.Show("Data berhasil diedit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgBoxError(string msg)
        {
            MessageBox.Show(msg, "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static bool ValidationNumber(TextBox text)
        {
            string str = text.Text.Trim();
            double val;
            bool isNum = double.TryParse(str, out val);
            if (isNum)
                return true;
            else
                return false;
        }

        public static void EventTextChange(TextBox txt)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (!ValidationNumber(txt))
                    txt.Clear();
                else
                    txt.Focus();
            }
        }
        #endregion
    }
}

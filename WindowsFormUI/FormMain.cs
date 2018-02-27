using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Preparations();
        }

        #region declaration
        private Dictionary<string, string> configDic;
        private string sourcePath = "";
        private string sinGrpPath = "";
        private string defGrpPath = "";
        private string warfGrpPath = "";
        private string rangerGrpPath = "";
        private string packageName = "";
        private bool generating = false;
        public delegate void UpdateContentDelegate();
        #endregion

        #region event
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string configContent = "";
            foreach (string eachConfig in configDic.Keys)
            {
                configContent += eachConfig + "=" + configDic[eachConfig] + "\n";
            }
            string configPath = AppDomain.CurrentDomain.BaseDirectory + "config.ini";
            if (System.IO.File.Exists(configPath))
            {
                System.IO.File.Delete(configPath);
            }
            System.IO.File.WriteAllText(configPath, configContent);
        }

        private void btnGenerateNP_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(this.sourcePath))
            {
                MessageBox.Show("Source directory error.");
                return;
            }
            this.packageName = this.tbxPackageName.Text.Trim();
            if (packageName == "")
            {
                MessageBox.Show("Package name is empty.");
                return;
            }
            if (this.generating)
            {
                MessageBox.Show("Already generating.");
                return;
            }
            this.generating = true;
            WaitCallback wcb = new WaitCallback(this.DoGeneratingNP);
            ThreadPool.QueueUserWorkItem(wcb, null);
        }

        private void btnGenerateHeadNP_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(this.sourcePath))
            {
                MessageBox.Show("Source directory error.");
                return;
            }
            this.packageName = this.tbxPackageName.Text.Trim();
            if (packageName == "")
            {
                MessageBox.Show("Package name is empty.");
                return;
            }
            if (this.generating)
            {
                MessageBox.Show("Already generating.");
                return;
            }
            this.generating = true;
            WaitCallback wcb = new WaitCallback(this.DoGeneratingHeadNP);
            ThreadPool.QueueUserWorkItem(wcb, null);
        }

        private void btnGenerateSinNP_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(this.sinGrpPath))
            {
                MessageBox.Show("Sin grp file error.");
                return;
            }
            if (!System.IO.File.Exists(this.defGrpPath))
            {
                MessageBox.Show("Def grp file error.");
                return;
            }
            this.packageName = this.tbxPackageName.Text.Trim();
            if (packageName == "")
            {
                MessageBox.Show("Package name is empty.");
                return;
            }
            if (this.generating)
            {
                MessageBox.Show("Already generating.");
                return;
            }
            this.generating = true;
            WaitCallback wcb = new WaitCallback(this.DoGeneratingSinNP);
            ThreadPool.QueueUserWorkItem(wcb, null);
        }

        private void btnGenerateBattleNP_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(this.warfGrpPath))
            {
                MessageBox.Show("warfId grp file error.");
                return;
            }
            this.packageName = this.tbxPackageName.Text.Trim();
            if (packageName == "")
            {
                MessageBox.Show("Package name is empty.");
                return;
            }
            if (this.generating)
            {
                MessageBox.Show("Already generating.");
                return;
            }
            this.generating = true;
            WaitCallback wcb = new WaitCallback(this.DoGeneratingWarfNP);
            ThreadPool.QueueUserWorkItem(wcb, null);
        }

        private void btnGenerateWorldNP_Click(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(this.sourcePath))
            {
                MessageBox.Show("Source directory error.");
                return;
            }
            this.packageName = this.tbxPackageName.Text.Trim();
            if (packageName == "")
            {
                MessageBox.Show("Package name is empty.");
                return;
            }
            if (this.generating)
            {
                MessageBox.Show("Already generating.");
                return;
            }
            this.generating = true;
            WaitCallback wcb = new WaitCallback(this.DoGeneratingWorldNP);
            ThreadPool.QueueUserWorkItem(wcb, null);
        }

        private void btnGenerateRangerNP_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(this.rangerGrpPath))
            {
                MessageBox.Show("rangerGrpPath path error.");
                return;
            }
            this.packageName = this.tbxPackageName.Text.Trim();
            if (packageName == "")
            {
                MessageBox.Show("Package name is empty.");
                return;
            }
            if (this.generating)
            {
                MessageBox.Show("Already generating.");
                return;
            }
            this.generating = true;
            WaitCallback wcb = new WaitCallback(this.DoGeneratingRangerNP);
            ThreadPool.QueueUserWorkItem(wcb, null);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (this.fbdSource.ShowDialog() == DialogResult.OK)
            {
                this.tbxSourceDirectory.Text = this.fbdSource.SelectedPath;
                this.sourcePath = this.fbdSource.SelectedPath;
                if (!configDic.ContainsKey("path"))
                {
                    configDic.Add("path", "");
                }
                configDic["path"] = this.fbdSource.SelectedPath;
            }
        }

        private void btnBrowseGRP_Click(object sender, EventArgs e)
        {
            if (this.ofdGRP.ShowDialog() == DialogResult.OK)
            {
                this.tbxGRPPath.Text = this.ofdGRP.FileName;
                this.sinGrpPath = this.ofdGRP.FileName;
                if (!configDic.ContainsKey("singrp"))
                {
                    configDic.Add("singrp", "");
                }
                configDic["singrp"] = this.ofdGRP.FileName;
            }
        }

        private void btnBrowseWarfGRP_Click(object sender, EventArgs e)
        {
            if (this.ofdGRP.ShowDialog() == DialogResult.OK)
            {
                this.tbxWarfGRPPath.Text = this.ofdGRP.FileName;
                this.warfGrpPath = this.ofdGRP.FileName;
                if (!configDic.ContainsKey("wargrp"))
                {
                    configDic.Add("wargrp", "");
                }
                configDic["wargrp"] = this.ofdGRP.FileName;
            }
        }

        private void btnBrowseAllDef_Click(object sender, EventArgs e)
        {
            if (this.ofdGRP.ShowDialog() == DialogResult.OK)
            {
                this.tbxAllDefPath.Text = this.ofdGRP.FileName;
                this.defGrpPath = this.ofdGRP.FileName;
                if (!configDic.ContainsKey("defgrp"))
                {
                    configDic.Add("defgrp", "");
                }
                configDic["defgrp"] = this.ofdGRP.FileName;
            }
        }

        private void btnBrowseRanger_Click(object sender, EventArgs e)
        {
            if (this.ofdGRP.ShowDialog() == DialogResult.OK)
            {
                this.tbxRangerGRPPath.Text = this.ofdGRP.FileName;
                this.rangerGrpPath = this.ofdGRP.FileName;
                if (!configDic.ContainsKey("rangergrp"))
                {
                    configDic.Add("rangergrp", "");
                }
                configDic["rangergrp"] = this.ofdGRP.FileName;
            }
        }
        #endregion

        #region business
        private void Preparations()
        {
            this.configDic = new Dictionary<string, string>();
            string configPath = AppDomain.CurrentDomain.BaseDirectory + "config.ini";
            if (System.IO.File.Exists(configPath))
            {
                string configContent = System.IO.File.ReadAllText(configPath);
                string[] configArray = configContent.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string eachConfig in configArray)
                {
                    string[] configPair = eachConfig.Split(new string[] { "=" }, StringSplitOptions.None);
                    if (configPair.Length > 1)
                    {
                        configDic.Add(configPair[0].ToLower(), configPair[1].ToLower());
                    }
                }
            }
            if (configDic.ContainsKey("path"))
            {
                this.fbdSource.SelectedPath = configDic["path"];
                this.tbxSourceDirectory.Text = configDic["path"];
                this.sourcePath = configDic["path"];
            }
            if (configDic.ContainsKey("singrp"))
            {
                this.tbxGRPPath.Text = configDic["singrp"];
                this.sinGrpPath = configDic["singrp"];
            }
            if (configDic.ContainsKey("defgrp"))
            {
                this.tbxAllDefPath.Text = configDic["defgrp"];
                this.defGrpPath = configDic["defgrp"];
            }
            if (configDic.ContainsKey("warfgrp"))
            {
                this.tbxWarfGRPPath.Text = configDic["warfgrp"];
                this.warfGrpPath = configDic["warfgrp"];
            }
            if (configDic.ContainsKey("rangergrp"))
            {
                this.tbxWarfGRPPath.Text = configDic["rangergrp"];
                this.warfGrpPath = configDic["rangergrp"];
            }
        }

        private void DoGeneratingWorldNP(object pmMain = null)
        {
            try
            {
                string FileEarth002 = this.sourcePath + "\\Earth.002";
                if (!System.IO.File.Exists(FileEarth002))
                {
                    this.UpdateHint("Can not find file : " + FileEarth002);
                    throw new Exception();
                }
                string FileSurface002 = this.sourcePath + "\\Surface.002";
                if (!System.IO.File.Exists(FileSurface002))
                {
                    this.UpdateHint("Can not find file : " + FileSurface002);
                    throw new Exception();
                }
                string FileBuilding002 = this.sourcePath + "\\Building.002";
                if (!System.IO.File.Exists(FileBuilding002))
                {
                    this.UpdateHint("Can not find file : " + FileBuilding002);
                    throw new Exception();
                }
                string FileBuildX002 = this.sourcePath + "\\Buildx.002";
                if (!System.IO.File.Exists(FileBuildX002))
                {
                    this.UpdateHint("Can not find file : " + FileBuildX002);
                    throw new Exception();
                }
                string FileBuildY002 = this.sourcePath + "\\Buildy.002";
                if (!System.IO.File.Exists(FileBuildY002))
                {
                    this.UpdateHint("Can not find file : " + FileBuildY002);
                    throw new Exception();
                }
                byte[] earth002Bytes = System.IO.File.ReadAllBytes(FileEarth002);
                byte[] surface002Bytes = System.IO.File.ReadAllBytes(FileSurface002);
                byte[] building002Bytes = System.IO.File.ReadAllBytes(FileBuilding002);
                byte[] buildX002Bytes = System.IO.File.ReadAllBytes(FileBuildX002);
                byte[] buildY002Bytes = System.IO.File.ReadAllBytes(FileBuildY002);
                List<byte> npByteList = new List<byte>();
                npByteList.AddRange(earth002Bytes);
                npByteList.AddRange(surface002Bytes);
                npByteList.AddRange(building002Bytes);
                npByteList.AddRange(buildX002Bytes);
                npByteList.AddRange(buildY002Bytes);
                this.UpdateHint(" saving package...");
                string resultFile = AppDomain.CurrentDomain.BaseDirectory + "Output\\" + packageName + ".np";
                if (System.IO.File.Exists(resultFile))
                {
                    System.IO.File.Delete(resultFile);
                }
                //System.IO.File.AppendAllText(resultFile, "");
                System.IO.File.WriteAllBytes(resultFile, npByteList.ToArray());
                this.UpdateHint("Generating finish.");
                MessageBox.Show("Generating finished.");
            }
            catch (Exception exp)
            {
                this.UpdateHint("Error occured : " + exp.Message);
            }
            this.generating = false;
        }

        private void DoGeneratingRangerNP(object pmMain = null)
        {
            try
            {
                if (!System.IO.File.Exists(rangerGrpPath))
                {
                    this.UpdateHint("Can not find file : " + rangerGrpPath);
                    throw new Exception();
                }

                byte[] rangerGrpBytes = System.IO.File.ReadAllBytes(rangerGrpPath);
                int playerLength = 0xfc6;
                int characterLength = 0x1e936 - playerLength;
                int itemLength = 0x3895e - characterLength - playerLength;
                int sceneLength = 0x3a0fe - itemLength - characterLength - playerLength;
                int skillLength = 0x46bc6 - sceneLength - itemLength - characterLength - playerLength;
                int shopLength = 0x46c5c - skillLength - sceneLength - itemLength - characterLength - playerLength;
                int checkPos = 0;

                List<byte> npByteList = new List<byte>();
                npByteList.AddRange(BitConverter.GetBytes(playerLength + 4));
                npByteList.AddRange(rangerGrpBytes.Skip(checkPos).Take(playerLength));
                checkPos += playerLength;
                npByteList.AddRange(BitConverter.GetBytes(characterLength + 4));
                npByteList.AddRange(rangerGrpBytes.Skip(checkPos).Take(characterLength));
                checkPos += characterLength;
                npByteList.AddRange(BitConverter.GetBytes(itemLength + 4));
                npByteList.AddRange(rangerGrpBytes.Skip(checkPos).Take(itemLength));
                checkPos += itemLength;
                byte[] tempSceneBytes = rangerGrpBytes.Skip(checkPos).Take(sceneLength).ToArray();
                checkPos += sceneLength;
                npByteList.AddRange(BitConverter.GetBytes(skillLength + 4));
                npByteList.AddRange(rangerGrpBytes.Skip(checkPos).Take(skillLength));
                checkPos += skillLength;
                npByteList.AddRange(BitConverter.GetBytes(shopLength + 4));
                npByteList.AddRange(rangerGrpBytes.Skip(checkPos).Take(shopLength));
                this.UpdateHint(" saving package...");
                string resultFile = AppDomain.CurrentDomain.BaseDirectory + "Output\\ranger0.np";
                if (System.IO.File.Exists(resultFile))
                {
                    System.IO.File.Delete(resultFile);
                }
                //System.IO.File.AppendAllText(resultFile, "");
                System.IO.File.WriteAllBytes(resultFile, npByteList.ToArray());

                resultFile = AppDomain.CurrentDomain.BaseDirectory + "Output\\tempScene.np";
                if (System.IO.File.Exists(resultFile))
                {
                    System.IO.File.Delete(resultFile);
                }
                //System.IO.File.AppendAllText(resultFile, "");
                System.IO.File.WriteAllBytes(resultFile, tempSceneBytes);
                this.UpdateHint("Generating finish.");
                MessageBox.Show("Generating finished.");
            }
            catch (Exception exp)
            {
                this.UpdateHint("Error occured : " + exp.Message);
            }
            this.generating = false;
        }

        private void DoGeneratingNP(object pmMain = null)
        {
            try
            {
                string indexkaFile = this.sourcePath + "\\index.ka";
                if (!System.IO.File.Exists(indexkaFile))
                {
                    this.UpdateHint("Can not find file : " + indexkaFile);
                    throw new Exception();
                }
                string zeroImgFile = this.sourcePath + "\\0.png";
                if (!System.IO.File.Exists(zeroImgFile))
                {
                    this.UpdateHint("Can not find file : " + zeroImgFile);
                    throw new Exception();
                }
                byte[] indexkaBytes = System.IO.File.ReadAllBytes(indexkaFile);
                byte[] zeroIMGBytes = System.IO.File.ReadAllBytes(zeroImgFile);
                Image zeroIMG = Image.FromFile(zeroImgFile);
                int maxIMGCount = indexkaBytes.Length / 4;
                int imgCount = 0;
                short width = 0, height = 0, xGap = 0, yGap = 0;
                int imgTotalLength = 0;
                string imgFile = "";
                List<byte> npByteList = new List<byte>();
                npByteList.AddRange(BitConverter.GetBytes(maxIMGCount));
                while (imgCount < maxIMGCount)
                {
                    if (imgCount % 10 == 0)
                    {
                        this.UpdateHint(imgCount + "/" + maxIMGCount);
                    }
                    xGap = BitConverter.ToInt16(indexkaBytes, imgCount * 4);
                    yGap = BitConverter.ToInt16(indexkaBytes, imgCount * 4 + 2);

                    imgFile = this.sourcePath + "\\" + imgCount.ToString() + ".png";
                    if (System.IO.File.Exists(imgFile))
                    {
                        Image imgEntity = Image.FromFile(imgFile);
                        width = (short)imgEntity.Width;
                        height = (short)imgEntity.Height;
                        byte[] imgBytes = System.IO.File.ReadAllBytes(imgFile);
                        imgTotalLength = 4 + 2 + 2 + 2 + 2 + imgBytes.Length;
                        npByteList.AddRange(BitConverter.GetBytes(imgTotalLength));
                        npByteList.AddRange(BitConverter.GetBytes(width));
                        npByteList.AddRange(BitConverter.GetBytes(height));
                        npByteList.AddRange(BitConverter.GetBytes(xGap));
                        npByteList.AddRange(BitConverter.GetBytes(yGap));
                        npByteList.AddRange(imgBytes);
                    }
                    else
                    {
                        this.UpdateHint("Can not find file : " + imgFile + " , use img 0 instead.");
                        width = (short)zeroIMG.Width;
                        height = (short)zeroIMG.Height;
                        imgTotalLength = 4 + 2 + 2 + 2 + 2 + zeroIMGBytes.Length;
                        npByteList.AddRange(BitConverter.GetBytes(imgTotalLength));
                        npByteList.AddRange(BitConverter.GetBytes(width));
                        npByteList.AddRange(BitConverter.GetBytes(height));
                        npByteList.AddRange(BitConverter.GetBytes(xGap));
                        npByteList.AddRange(BitConverter.GetBytes(yGap));
                        npByteList.AddRange(zeroIMGBytes);
                    }

                    imgCount++;
                }
                this.UpdateHint(imgCount + "/" + maxIMGCount + " saving package...");
                string resultFile = AppDomain.CurrentDomain.BaseDirectory + "Output\\" + packageName + ".np";
                if (System.IO.File.Exists(resultFile))
                {
                    System.IO.File.Delete(resultFile);
                }
                //System.IO.File.AppendAllText(resultFile, "");
                System.IO.File.WriteAllBytes(resultFile, npByteList.ToArray());
                this.UpdateHint("Generating finish.");
                MessageBox.Show("Generating finished.");
            }
            catch (Exception exp)
            {
                this.UpdateHint("Error occured : " + exp.Message);
            }
            this.generating = false;
        }

        private void DoGeneratingHeadNP(object pmMain = null)
        {
            try
            {
                string zeroImgFile = this.sourcePath + "\\0.png";
                if (!System.IO.File.Exists(zeroImgFile))
                {
                    this.UpdateHint("Can not find file : " + zeroImgFile);
                    throw new Exception();
                }
                Image zeroIMGEntity = Image.FromFile(zeroImgFile);
                byte[] zeroIMGBytes = System.IO.File.ReadAllBytes(zeroImgFile);
                int maxIMGCount = 100;
                int imgCount = 0;
                short width = 0, height = 0, xGap = 0, yGap = 0;
                int imgTotalLength = 0;
                string imgFile = "";
                List<byte> npByteList = new List<byte>();
                npByteList.AddRange(BitConverter.GetBytes(maxIMGCount));
                while (imgCount < maxIMGCount)
                    while (imgCount < maxIMGCount)
                    {
                        if (imgCount % 10 == 0)
                        {
                            this.UpdateHint(imgCount + "/" + maxIMGCount);
                        }
                        imgFile = this.sourcePath + "\\" + imgCount.ToString() + ".png";
                        if (System.IO.File.Exists(imgFile))
                        {
                            byte[] imgBytes = System.IO.File.ReadAllBytes(imgFile);
                            Image checkIMGEntity = Image.FromFile(imgFile);
                            width = (short)checkIMGEntity.Width;
                            height = (short)checkIMGEntity.Height;
                            imgTotalLength = 4 + 2 + 2 + 2 + 2 + imgBytes.Length;
                            npByteList.AddRange(BitConverter.GetBytes(imgTotalLength));
                            npByteList.AddRange(BitConverter.GetBytes(width));
                            npByteList.AddRange(BitConverter.GetBytes(height));
                            npByteList.AddRange(BitConverter.GetBytes(xGap));
                            npByteList.AddRange(BitConverter.GetBytes(yGap));
                            npByteList.AddRange(imgBytes);
                        }
                        else
                        {
                            this.UpdateHint("Can not find file : " + imgFile + " , use img 0 instead.");
                            width = (short)zeroIMGEntity.Width;
                            height = (short)zeroIMGEntity.Height;
                            imgTotalLength = 4 + 2 + 2 + 2 + 2 + zeroIMGBytes.Length;
                            npByteList.AddRange(BitConverter.GetBytes(imgTotalLength));
                            npByteList.AddRange(BitConverter.GetBytes(width));
                            npByteList.AddRange(BitConverter.GetBytes(height));
                            npByteList.AddRange(BitConverter.GetBytes(xGap));
                            npByteList.AddRange(BitConverter.GetBytes(yGap));
                            npByteList.AddRange(zeroIMGBytes);
                        }

                        imgCount++;
                    }
                this.UpdateHint(imgCount + "/" + maxIMGCount + " saving package...");
                string resultFile = AppDomain.CurrentDomain.BaseDirectory + "Output\\" + packageName + ".np";
                if (System.IO.File.Exists(resultFile))
                {
                    System.IO.File.Delete(resultFile);
                }
                //System.IO.File.AppendAllText(resultFile, "");
                System.IO.File.WriteAllBytes(resultFile, npByteList.ToArray());
                this.UpdateHint("Generating finish.");
                MessageBox.Show("Generating finished.");
            }
            catch (Exception exp)
            {
                this.UpdateHint("Error occured : " + exp.Message);
            }
            this.generating = false;
        }

        private void DoGeneratingSinNP(object pmMain = null)
        {
            try
            {
                string tempSceneFile = @"D:\Dev\JYQXZ\JYQXZNOperator\WindowsFormUI\bin\Debug\Output\tempScene.np";
                byte[] tempSceneBytes = System.IO.File.ReadAllBytes(tempSceneFile);
                string sinGrpName = this.sinGrpPath.Substring(0, this.sinGrpPath.LastIndexOf('.'));
                string sinIdxPath = sinGrpName + ".idx";
                string defGrpName = this.defGrpPath.Substring(0, this.defGrpPath.LastIndexOf('.'));
                string defIdxPath = defGrpName + ".idx";
                if (!System.IO.File.Exists(sinGrpPath))
                {
                    this.UpdateHint("Can not find file : " + sinGrpPath);
                    throw new Exception();
                }
                if (!System.IO.File.Exists(sinIdxPath))
                {
                    this.UpdateHint("Can not find file : " + sinIdxPath);
                    throw new Exception();
                }
                if (!System.IO.File.Exists(defGrpPath))
                {
                    this.UpdateHint("Can not find file : " + defGrpPath);
                    throw new Exception();
                }
                if (!System.IO.File.Exists(defIdxPath))
                {
                    this.UpdateHint("Can not find file : " + defIdxPath);
                    throw new Exception();
                }
                byte[] sinGrpBytes = System.IO.File.ReadAllBytes(sinGrpPath);
                byte[] sinIdxBytes = System.IO.File.ReadAllBytes(sinIdxPath);
                int totalCount = sinIdxBytes.Length / 4;
                int eachSize = 0x8000;
                List<byte> npByteList = new List<byte>();
                npByteList.AddRange(BitConverter.GetBytes(totalCount));
                int checkCount = 0;
                int startPos = 0;
                while (checkCount < totalCount)
                {
                    if (checkCount > 0)
                    {
                        startPos = BitConverter.ToInt32(sinIdxBytes, (checkCount - 1) * 4);
                    }
                    else
                    {
                        startPos = 0;
                    }
                    npByteList.AddRange(sinGrpBytes.Skip(startPos).Take(eachSize));
                    checkCount++;
                }

                byte[] defGrpBytes = System.IO.File.ReadAllBytes(defGrpPath);
                byte[] defIdxBytes = System.IO.File.ReadAllBytes(defIdxPath);
                totalCount = defIdxBytes.Length / 4;
                eachSize = 0x1130;
                npByteList.AddRange(defGrpBytes);
                npByteList.AddRange(tempSceneBytes);

                this.UpdateHint("saving package...");
                string resultFile = AppDomain.CurrentDomain.BaseDirectory + "Output\\" + packageName + ".np";
                if (System.IO.File.Exists(resultFile))
                {
                    System.IO.File.Delete(resultFile);
                }
                //System.IO.File.AppendAllText(resultFile, "");
                System.IO.File.WriteAllBytes(resultFile, npByteList.ToArray());
                this.UpdateHint("Generating finish.");
                MessageBox.Show("Generating finished.");
            }
            catch (Exception exp)
            {
                this.UpdateHint("Error occured : " + exp.Message);
            }
            this.generating = false;
        }

        private void DoGeneratingWarfNP(object pmMain = null)
        {
            try
            {
                if (!System.IO.File.Exists(warfGrpPath))
                {
                    this.UpdateHint("Can not find file : " + warfGrpPath);
                    throw new Exception();
                }
                byte[] warfGrpBytes = System.IO.File.ReadAllBytes(warfGrpPath);
                int totalCount = warfGrpBytes.Length / 0x4000;
                int eachSize = 0x4000;
                List<byte> npByteList = new List<byte>();
                npByteList.AddRange(BitConverter.GetBytes(totalCount));
                npByteList.AddRange(warfGrpBytes);

                this.UpdateHint("saving package...");
                string resultFile = AppDomain.CurrentDomain.BaseDirectory + "Output\\" + packageName + ".np";
                if (System.IO.File.Exists(resultFile))
                    if (System.IO.File.Exists(resultFile))
                        if (System.IO.File.Exists(resultFile))
                        {
                            System.IO.File.Delete(resultFile);
                        }
                //System.IO.File.AppendAllText(resultFile, "");
                System.IO.File.WriteAllBytes(resultFile, npByteList.ToArray());
                this.UpdateHint("Generating finish.");
                MessageBox.Show("Generating finished.");
            }
            catch (Exception exp)
            {
                this.UpdateHint("Error occured : " + exp.Message);
            }
            this.generating = false;
        }

        private void UpdateHint(string pmHint)
        {
            if (this.lblHint.InvokeRequired)
            {
                this.lblHint.Invoke(new UpdateContentDelegate(delegate
                {
                    this.lblHint.Text = pmHint;
                }));
            }
            else
            {
                this.lblHint.Text = pmHint;
            }
        }
        #endregion
    }
}
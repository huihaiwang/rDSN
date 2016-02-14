/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2015 Microsoft Corporation
 * 
 * -=- Robust Distributed System Nucleus (rDSN) -=- 
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

/*
 * Description:
 *     What is this file about?
 *
 * Revision history:
 *     Feb., 2016, @imzhenyu (Zhenyu Guo), done in Tron project and copied here
 *     xxxx-xx-xx, author, fix bug about xxx
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

using BondNetlibTransport;
using BondTransport;

using rDSN.Tron.Utility;
using rDSN.Tron.Runtime;

namespace rDSN.Tron.ControlPanel
{
    public class QueryServicePackageCommand : Command
    {
        public QueryServicePackageCommand()
        {
            _transport = new NetlibTransport(new BinaryProtocolFactory());
            _saveDir = Configuration.Instance().Get<string>("ServicePackageSaveDir", Path.Combine(Directory.GetCurrentDirectory(), "ServicePackage"));
            if (!Directory.Exists(_saveDir))
            {
                Directory.CreateDirectory(_saveDir);
            }

            InitProxy();
        }

        public override bool Execute(List<string> args)
        {
            var req = new Name();
            if (args.Count > 0)
            {
                if ((args[0] != "ByName" && args[0] != "ByMethod") || args.Count < 2)
                {
                    Console.WriteLine(Usage());
                    return false;
                }
                req.Value = args[1];
            }

            for (int ik = 0; ik < 2; ik++)
            {
                try
                {
                    if (args.Count == 0 || args[0] == "ByMethod")
                    {
                        var resp = _proxy.QueryServicePackage(req);

                        Console.WriteLine("query service package ...");
                        if (resp.Code == 0)
                        {
                            foreach (var s in resp.Value.Names)
                            {
                                Console.WriteLine("\t" + s);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\t" + "QueryServicePackageBySpecName failed, err = " + ((ErrorCode)resp.Code).ToString());
                        }
                    }
                    else
                    {
                        var resp = _proxy.GetServicePackageByName(req);

                        ErrorCode c = (ErrorCode)resp.Code;
                        Console.WriteLine("query error code: " + c.ToString());

                        if (c == ErrorCode.Success)
                        {
                            var sc = resp.Value;

                            SystemHelper.ByteArrayToFile(
                                sc.PackageZip.Data.Array,
                                sc.PackageZip.Data.Offset,
                                sc.PackageZip.Data.Count,
                                Path.Combine(_saveDir, sc.Name) + ".zip"
                                );

                            SystemHelper.RemoveAllExcept(Path.Combine(_saveDir, sc.Name), new string[] { });

                            ZipFile.ExtractToDirectory(
                                Path.Combine(_saveDir, sc.Name) + ".zip",
                                Path.Combine(_saveDir, sc.Name)
                                );

                            Console.WriteLine("Service implementation downloaded to " + Path.Combine(_saveDir, sc.Name));

                            sc.Echo(req.Value, 0);
                        }
                    }

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("exception, msg = " + e.Message);
                    InitProxy();
                }
            }

            return false;
        }

        private void InitProxy()
        {
            NodeAddress storeAddress = new NodeAddress();
            storeAddress.Host = Configuration.Instance().Get<string>("ServiceStore", "Host", "localhost");
            storeAddress.Port = Configuration.Instance().Get<int>("ServiceStore", "Port", 19995);

            _proxy = new ServiceStore_Proxy(_transport.Connect(storeAddress.Host, storeAddress.Port));
        }
        
        public override string Help()
        {
            return "QueryPackage|QP|qp ByName|ByMethod [ServicePackageName|ServiceMethodName] ...";
        }

        public override string Usage()
        {
            return Help();
        }

        private ITransport _transport;
        private ServiceStore_Proxy _proxy;
        private string _saveDir;
    }
}

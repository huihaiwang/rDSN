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
 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Tool     : bondc, Version=3.0.1, Build=bond-git.retail.not
//     Template : Microsoft.Bond.Rules.dll#Rules_Bond_CSharp.tt
//     File     : ServiceStore_proxies.cs
//
//     Changes to this file may cause incorrect behavior and will be lost when
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::BondTransport;
using global::BondNetlibTransport;
using global::Microsoft.Bond;
using global::System;
using global::System.Collections.Generic;

namespace rDSN
{
namespace Tron
{

///<summary>
/// ServiceStore
///</summary>
[System.CodeDom.Compiler.GeneratedCode("bondc.exe", null)]
public class ServiceStore_Proxy : BondTransport.BondProxy
{
    //
    // Constructors
    //
    public ServiceStore_Proxy(IBondTransportClient client) : base(client, "Microsoft::Tron.ServiceStore")
    {
    }

    public ServiceStore_Proxy(IBondTransportClient client, string serviceName) : base(client, serviceName)
    {
    }

    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> RegisterServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage> input)
    {
        return RegisterServicePackage(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcError RegisterServicePackage(global::rDSN.Tron.ServicePackage input)
    {
        return RegisterServicePackage(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> RegisterServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginRegisterServicePackage(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndRegisterServicePackage(asyncResult);
        }
        CancelRegisterServicePackage(asyncResult);
        throw new global::System.TimeoutException("RegisterServicePackage");
    }

    public global::rDSN.Tron.RpcError RegisterServicePackage(global::rDSN.Tron.ServicePackage input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> resultMsg = RegisterServicePackage(inputMsg, timeout);
        global::rDSN.Tron.RpcError result = new global::rDSN.Tron.RpcError();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of RegisterServicePackage.
    //

    public IAsyncResult BeginRegisterServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage> input)
    {
        return BeginRegisterServicePackage(input, null, null);
    }

    public IAsyncResult BeginRegisterServicePackage(global::rDSN.Tron.ServicePackage input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage>(input);
        return BeginRegisterServicePackage(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginRegisterServicePackage(global::rDSN.Tron.ServicePackage input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage>(input);
        return BeginRegisterServicePackage(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginRegisterServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePackage> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.ServicePackage>("RegisterServicePackage", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> EndRegisterServicePackage(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcError>("RegisterServicePackage", asyncResult);
    }

    public void CancelRegisterServicePackage(IAsyncResult asyncResult)
    {
        CancelRequest("RegisterServicePackage", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> RemoveServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return RemoveServicePackage(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcError RemoveServicePackage(global::rDSN.Tron.Name input)
    {
        return RemoveServicePackage(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> RemoveServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginRemoveServicePackage(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndRemoveServicePackage(asyncResult);
        }
        CancelRemoveServicePackage(asyncResult);
        throw new global::System.TimeoutException("RemoveServicePackage");
    }

    public global::rDSN.Tron.RpcError RemoveServicePackage(global::rDSN.Tron.Name input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> resultMsg = RemoveServicePackage(inputMsg, timeout);
        global::rDSN.Tron.RpcError result = new global::rDSN.Tron.RpcError();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of RemoveServicePackage.
    //

    public IAsyncResult BeginRemoveServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return BeginRemoveServicePackage(input, null, null);
    }

    public IAsyncResult BeginRemoveServicePackage(global::rDSN.Tron.Name input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginRemoveServicePackage(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginRemoveServicePackage(global::rDSN.Tron.Name input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginRemoveServicePackage(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginRemoveServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.Name>("RemoveServicePackage", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> EndRemoveServicePackage(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcError>("RemoveServicePackage", asyncResult);
    }

    public void CancelRemoveServicePackage(IAsyncResult asyncResult)
    {
        CancelRequest("RemoveServicePackage", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage>> GetServicePackageByName(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return GetServicePackageByName(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage> GetServicePackageByName(global::rDSN.Tron.Name input)
    {
        return GetServicePackageByName(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage>> GetServicePackageByName(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginGetServicePackageByName(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndGetServicePackageByName(asyncResult);
        }
        CancelGetServicePackageByName(asyncResult);
        throw new global::System.TimeoutException("GetServicePackageByName");
    }

    public global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage> GetServicePackageByName(global::rDSN.Tron.Name input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage>> resultMsg = GetServicePackageByName(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage> result = new global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of GetServicePackageByName.
    //

    public IAsyncResult BeginGetServicePackageByName(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return BeginGetServicePackageByName(input, null, null);
    }

    public IAsyncResult BeginGetServicePackageByName(global::rDSN.Tron.Name input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginGetServicePackageByName(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginGetServicePackageByName(global::rDSN.Tron.Name input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginGetServicePackageByName(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginGetServicePackageByName(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.Name>("GetServicePackageByName", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage>> EndGetServicePackageByName(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePackage>>("GetServicePackageByName", asyncResult);
    }

    public void CancelGetServicePackageByName(IAsyncResult asyncResult)
    {
        CancelRequest("GetServicePackageByName", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList>> GetServiceList(global::Microsoft.Bond.Message<global::Microsoft.Bond.Void> input)
    {
        return GetServiceList(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList> GetServiceList()
    {
        return GetServiceList(Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList>> GetServiceList(global::Microsoft.Bond.Message<global::Microsoft.Bond.Void> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginGetServiceList(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndGetServiceList(asyncResult);
        }
        CancelGetServiceList(asyncResult);
        throw new global::System.TimeoutException("GetServiceList");
    }

    public global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList> GetServiceList(TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::Microsoft.Bond.Void> inputMsg = new global::Microsoft.Bond.Message<global::Microsoft.Bond.Void>();

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList>> resultMsg = GetServiceList(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList> result = new global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of GetServiceList.
    //

    public IAsyncResult BeginGetServiceList(global::Microsoft.Bond.Message<global::Microsoft.Bond.Void> input)
    {
        return BeginGetServiceList(input, null, null);
    }

    public IAsyncResult BeginGetServiceList()
    {
        global::Microsoft.Bond.Message<global::Microsoft.Bond.Void> inputMsg = new global::Microsoft.Bond.Message<global::Microsoft.Bond.Void>();
        return BeginGetServiceList(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginGetServiceList(AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::Microsoft.Bond.Void> inputMsg = new global::Microsoft.Bond.Message<global::Microsoft.Bond.Void>();
        return BeginGetServiceList(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginGetServiceList(global::Microsoft.Bond.Message<global::Microsoft.Bond.Void> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::Microsoft.Bond.Void>("GetServiceList", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList>> EndGetServiceList(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceList>>("GetServiceList", asyncResult);
    }

    public void CancelGetServiceList(IAsyncResult asyncResult)
    {
        CancelRequest("GetServiceList", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<BondBlob>> GetServiceCompositionAssembly(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return GetServiceCompositionAssembly(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<BondBlob> GetServiceCompositionAssembly(global::rDSN.Tron.Name input)
    {
        return GetServiceCompositionAssembly(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<BondBlob>> GetServiceCompositionAssembly(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginGetServiceCompositionAssembly(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndGetServiceCompositionAssembly(asyncResult);
        }
        CancelGetServiceCompositionAssembly(asyncResult);
        throw new global::System.TimeoutException("GetServiceCompositionAssembly");
    }

    public global::rDSN.Tron.RpcResponse<BondBlob> GetServiceCompositionAssembly(global::rDSN.Tron.Name input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<BondBlob>> resultMsg = GetServiceCompositionAssembly(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<BondBlob> result = new global::rDSN.Tron.RpcResponse<BondBlob>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of GetServiceCompositionAssembly.
    //

    public IAsyncResult BeginGetServiceCompositionAssembly(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return BeginGetServiceCompositionAssembly(input, null, null);
    }

    public IAsyncResult BeginGetServiceCompositionAssembly(global::rDSN.Tron.Name input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginGetServiceCompositionAssembly(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginGetServiceCompositionAssembly(global::rDSN.Tron.Name input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginGetServiceCompositionAssembly(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginGetServiceCompositionAssembly(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.Name>("GetServiceCompositionAssembly", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<BondBlob>> EndGetServiceCompositionAssembly(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<BondBlob>>("GetServiceCompositionAssembly", asyncResult);
    }

    public void CancelGetServiceCompositionAssembly(IAsyncResult asyncResult)
    {
        CancelRequest("GetServiceCompositionAssembly", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList>> QueryServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return QueryServicePackage(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList> QueryServicePackage(global::rDSN.Tron.Name input)
    {
        return QueryServicePackage(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList>> QueryServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginQueryServicePackage(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndQueryServicePackage(asyncResult);
        }
        CancelQueryServicePackage(asyncResult);
        throw new global::System.TimeoutException("QueryServicePackage");
    }

    public global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList> QueryServicePackage(global::rDSN.Tron.Name input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList>> resultMsg = QueryServicePackage(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList> result = new global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of QueryServicePackage.
    //

    public IAsyncResult BeginQueryServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return BeginQueryServicePackage(input, null, null);
    }

    public IAsyncResult BeginQueryServicePackage(global::rDSN.Tron.Name input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginQueryServicePackage(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginQueryServicePackage(global::rDSN.Tron.Name input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginQueryServicePackage(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginQueryServicePackage(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.Name>("QueryServicePackage", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList>> EndQueryServicePackage(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.NameList>>("QueryServicePackage", asyncResult);
    }

    public void CancelQueryServicePackage(IAsyncResult asyncResult)
    {
        CancelRequest("QueryServicePackage", asyncResult);
    }

}    // ~ ServiceStore_Proxy
} // namespace Tron
} // namespace rDSN

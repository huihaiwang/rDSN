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
//     File     : MetaServer_proxies.cs
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
/// MetaServer
///</summary>
[System.CodeDom.Compiler.GeneratedCode("bondc.exe", null)]
public class MetaServer_Proxy : BondTransport.BondProxy
{
    //
    // Constructors
    //
    public MetaServer_Proxy(IBondTransportClient client) : base(client, "Microsoft::Tron.MetaServer")
    {
    }

    public MetaServer_Proxy(IBondTransportClient client, string serviceName) : base(client, serviceName)
    {
    }

    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> CreateService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo> input)
    {
        return CreateService(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcError CreateService(global::rDSN.Tron.ServiceInfo input)
    {
        return CreateService(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> CreateService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginCreateService(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndCreateService(asyncResult);
        }
        CancelCreateService(asyncResult);
        throw new global::System.TimeoutException("CreateService");
    }

    public global::rDSN.Tron.RpcError CreateService(global::rDSN.Tron.ServiceInfo input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> resultMsg = CreateService(inputMsg, timeout);
        global::rDSN.Tron.RpcError result = new global::rDSN.Tron.RpcError();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of CreateService.
    //

    public IAsyncResult BeginCreateService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo> input)
    {
        return BeginCreateService(input, null, null);
    }

    public IAsyncResult BeginCreateService(global::rDSN.Tron.ServiceInfo input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo>(input);
        return BeginCreateService(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginCreateService(global::rDSN.Tron.ServiceInfo input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo>(input);
        return BeginCreateService(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginCreateService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServiceInfo> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.ServiceInfo>("CreateService", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> EndCreateService(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcError>("CreateService", asyncResult);
    }

    public void CancelCreateService(IAsyncResult asyncResult)
    {
        CancelRequest("CreateService", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> RemoveService(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return RemoveService(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcError RemoveService(global::rDSN.Tron.Name input)
    {
        return RemoveService(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> RemoveService(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginRemoveService(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndRemoveService(asyncResult);
        }
        CancelRemoveService(asyncResult);
        throw new global::System.TimeoutException("RemoveService");
    }

    public global::rDSN.Tron.RpcError RemoveService(global::rDSN.Tron.Name input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> resultMsg = RemoveService(inputMsg, timeout);
        global::rDSN.Tron.RpcError result = new global::rDSN.Tron.RpcError();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of RemoveService.
    //

    public IAsyncResult BeginRemoveService(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input)
    {
        return BeginRemoveService(input, null, null);
    }

    public IAsyncResult BeginRemoveService(global::rDSN.Tron.Name input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginRemoveService(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginRemoveService(global::rDSN.Tron.Name input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.Name> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.Name>(input);
        return BeginRemoveService(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginRemoveService(global::Microsoft.Bond.Message<global::rDSN.Tron.Name> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.Name>("RemoveService", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcError> EndRemoveService(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcError>("RemoveService", asyncResult);
    }

    public void CancelRemoveService(IAsyncResult asyncResult)
    {
        CancelRequest("RemoveService", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse>> QueryServices(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input)
    {
        return QueryServices(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse> QueryServices(global::rDSN.Tron.NameList input)
    {
        return QueryServices(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse>> QueryServices(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginQueryServices(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndQueryServices(asyncResult);
        }
        CancelQueryServices(asyncResult);
        throw new global::System.TimeoutException("QueryServices");
    }

    public global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse> QueryServices(global::rDSN.Tron.NameList input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.NameList>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse>> resultMsg = QueryServices(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse> result = new global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of QueryServices.
    //

    public IAsyncResult BeginQueryServices(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input)
    {
        return BeginQueryServices(input, null, null);
    }

    public IAsyncResult BeginQueryServices(global::rDSN.Tron.NameList input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.NameList>(input);
        return BeginQueryServices(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginQueryServices(global::rDSN.Tron.NameList input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.NameList>(input);
        return BeginQueryServices(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginQueryServices(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.NameList>("QueryServices", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse>> EndQueryServices(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServiceListResponse>>("QueryServices", asyncResult);
    }

    public void CancelQueryServices(IAsyncResult asyncResult)
    {
        CancelRequest("QueryServices", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse>> QueryServersByAddress(global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest> input)
    {
        return QueryServersByAddress(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse> QueryServersByAddress(global::rDSN.Tron.ServerListRequest input)
    {
        return QueryServersByAddress(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse>> QueryServersByAddress(global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginQueryServersByAddress(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndQueryServersByAddress(asyncResult);
        }
        CancelQueryServersByAddress(asyncResult);
        throw new global::System.TimeoutException("QueryServersByAddress");
    }

    public global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse> QueryServersByAddress(global::rDSN.Tron.ServerListRequest input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse>> resultMsg = QueryServersByAddress(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse> result = new global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of QueryServersByAddress.
    //

    public IAsyncResult BeginQueryServersByAddress(global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest> input)
    {
        return BeginQueryServersByAddress(input, null, null);
    }

    public IAsyncResult BeginQueryServersByAddress(global::rDSN.Tron.ServerListRequest input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest>(input);
        return BeginQueryServersByAddress(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginQueryServersByAddress(global::rDSN.Tron.ServerListRequest input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest>(input);
        return BeginQueryServersByAddress(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginQueryServersByAddress(global::Microsoft.Bond.Message<global::rDSN.Tron.ServerListRequest> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.ServerListRequest>("QueryServersByAddress", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse>> EndQueryServersByAddress(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse>>("QueryServersByAddress", asyncResult);
    }

    public void CancelQueryServersByAddress(IAsyncResult asyncResult)
    {
        CancelRequest("QueryServersByAddress", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2>> QueryServersByName(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input)
    {
        return QueryServersByName(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2> QueryServersByName(global::rDSN.Tron.NameList input)
    {
        return QueryServersByName(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2>> QueryServersByName(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginQueryServersByName(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndQueryServersByName(asyncResult);
        }
        CancelQueryServersByName(asyncResult);
        throw new global::System.TimeoutException("QueryServersByName");
    }

    public global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2> QueryServersByName(global::rDSN.Tron.NameList input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.NameList>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2>> resultMsg = QueryServersByName(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2> result = new global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of QueryServersByName.
    //

    public IAsyncResult BeginQueryServersByName(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input)
    {
        return BeginQueryServersByName(input, null, null);
    }

    public IAsyncResult BeginQueryServersByName(global::rDSN.Tron.NameList input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.NameList>(input);
        return BeginQueryServersByName(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginQueryServersByName(global::rDSN.Tron.NameList input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.NameList>(input);
        return BeginQueryServersByName(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginQueryServersByName(global::Microsoft.Bond.Message<global::rDSN.Tron.NameList> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.NameList>("QueryServersByName", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2>> EndQueryServersByName(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServerListResponse2>>("QueryServersByName", asyncResult);
    }

    public void CancelQueryServersByName(IAsyncResult asyncResult)
    {
        CancelRequest("QueryServersByName", asyncResult);
    }


    public global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo>> PlaceService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest> input)
    {
        return PlaceService(input, Infinite);
    }

    public virtual global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo> PlaceService(global::rDSN.Tron.ServicePlaceRequest input)
    {
        return PlaceService(input, Infinite);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo>> PlaceService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest> input, TimeSpan timeout)
    {
        IAsyncResult asyncResult = BeginPlaceService(input);
        if (asyncResult.AsyncWaitHandle.WaitOne(timeout, false))
        {
            return EndPlaceService(asyncResult);
        }
        CancelPlaceService(asyncResult);
        throw new global::System.TimeoutException("PlaceService");
    }

    public global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo> PlaceService(global::rDSN.Tron.ServicePlaceRequest input, TimeSpan timeout)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest>(input);

        global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo>> resultMsg = PlaceService(inputMsg, timeout);
        global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo> result = new global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo>();
        resultMsg.Payload.Deserialize(result);
        return result;
    }

    //
    // Async invocation of PlaceService.
    //

    public IAsyncResult BeginPlaceService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest> input)
    {
        return BeginPlaceService(input, null, null);
    }

    public IAsyncResult BeginPlaceService(global::rDSN.Tron.ServicePlaceRequest input)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest>(input);
        return BeginPlaceService(inputMsg, null, null);
    }

    public virtual IAsyncResult BeginPlaceService(global::rDSN.Tron.ServicePlaceRequest input, AsyncCallback userCallback, object stateObject)
    {
        global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest> inputMsg = new global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest>(input);
        return BeginPlaceService(inputMsg, userCallback, stateObject);
    }

    public virtual IAsyncResult BeginPlaceService(global::Microsoft.Bond.Message<global::rDSN.Tron.ServicePlaceRequest> input, AsyncCallback userCallback, Object stateObject)
    {
        return BeginRequest<global::rDSN.Tron.ServicePlaceRequest>("PlaceService", input, userCallback, stateObject);
    }

    public virtual global::Microsoft.Bond.Message<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo>> EndPlaceService(IAsyncResult asyncResult)
    {
        return EndRequest<global::rDSN.Tron.RpcResponse<global::rDSN.Tron.ServicePartitionInfo>>("PlaceService", asyncResult);
    }

    public void CancelPlaceService(IAsyncResult asyncResult)
    {
        CancelRequest("PlaceService", asyncResult);
    }

}    // ~ MetaServer_Proxy
} // namespace Tron
} // namespace rDSN

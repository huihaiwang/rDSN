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
 *     xxxx-xx-xx, author, first version
 *     xxxx-xx-xx, author, fix bug about xxx
 */

#pragma once

#include <dsn/internal/task_spec.h>

DEFINE_THREAD_POOL_CODE(THREAD_POOL_META_SERVER)
DEFINE_THREAD_POOL_CODE(THREAD_POOL_REPLICATION)
DEFINE_THREAD_POOL_CODE(THREAD_POOL_LOCAL_APP)
DEFINE_THREAD_POOL_CODE(THREAD_POOL_REPLICATION_LONG)

#define MAKE_EVENT_CODE(x, pri) DEFINE_TASK_CODE(x, pri, CURRENT_THREAD_POOL)
#define MAKE_EVENT_CODE_AIO(x, pri) DEFINE_TASK_CODE_AIO(x, pri, CURRENT_THREAD_POOL)
#define MAKE_EVENT_CODE_RPC(x, pri) DEFINE_TASK_CODE_RPC(x, pri, CURRENT_THREAD_POOL)

// THREAD_POOL_DEFAULT
#define CURRENT_THREAD_POOL dsn::THREAD_POOL_DEFAULT
MAKE_EVENT_CODE(LPC_MUTATION_LOG_PENDING_TIMER, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_ASYNC_READ_COMPLETE, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_ASYNC_WRITE_COMPLETE, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_REPLICA_STATE_CHANGE_NOTIFICATION, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_REPORT, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_TEST, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_TEST2, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_TEST3, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_TEST4, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_TEST, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_TEST_AGENT_WRITE, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_TEST_AGENT_READ, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_AIO_TEST, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_AIO_IMMEDIATE_CALLBACK, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_WRITE_REPLICATION_LOG_FLUSH, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_AIO(LPC_WRITE_REPLICATION_LOG_WITHOUT_FLUSH, TASK_PRIORITY_HIGH)
#undef CURRENT_THREAD_POOL

// THREAD_POOL_META_SERVER
#define CURRENT_THREAD_POOL THREAD_POOL_META_SERVER
MAKE_EVENT_CODE_RPC(RPC_CM_QUERY_PARTITION_CONFIG_BY_INDEX, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CM_QUERY_NODE_PARTITIONS, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CM_UPDATE_PARTITION_CONFIGURATION, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CM_MODIFY_REPLICA_CONFIG_COMMAND, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CM_CREATE_APP, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CM_DROP_APP, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CM_LIST_APPS, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CM_LIST_NODES, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_CM_LOG_UPDATE, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_LBM_RUN, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_LBM_START, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_QUERY_PN_DECREE, TASK_PRIORITY_COMMON)
#undef CURRENT_THREAD_POOL

// THREAD_POOL_REPLICATION
#define CURRENT_THREAD_POOL THREAD_POOL_REPLICATION
MAKE_EVENT_CODE(RPC_REPLICATION_WRITE_EMPTY, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_PER_REPLICA_CHECKPOINT_TIMER, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_MUTATION_PENDING_TIMER, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_GROUP_CHECK, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_CM_DISCONNECTED_SCATTER, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_QUERY_NODE_CONFIGURATION_SCATTER, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_DELAY_LEARN, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_LEARN_REMOTE_DELTA_FILES_COMPLETED, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_CHECKPOINT_REPLICA_COMPLETED, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_SIM_UPDATE_PARTITION_CONFIGURATION_REPLY, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_WRITE_REPLICATION_LOG, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_AIO(LPC_LERARN_REMOTE_DISK_STATE, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE(LPC_QUERY_CONFIGURATION_ALL, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_RPC(RPC_REPLICATION_CLIENT_WRITE, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_CONFIG_PROPOSAL, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_RPC(RPC_QUERY_PN_DECREE, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_RPC(RPC_PREPARE, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_RPC(RPC_GROUP_CHECK, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_LEARN, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_RPC(RPC_LEARN_COMPLETION_NOTIFY, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_RPC(RPC_LEARN_ADD_LEARNER, TASK_PRIORITY_HIGH)
MAKE_EVENT_CODE_RPC(RPC_REMOVE_REPLICA, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_REPLICA_COPY_LAST_CHECKPOINT, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_REPLICA_COPY_LAST_CHECKPOINT_DONE, TASK_PRIORITY_COMMON)
#undef CURRENT_THREAD_POOL

// THREAD_POOL_LOCAL_APP
#define CURRENT_THREAD_POOL THREAD_POOL_LOCAL_APP
MAKE_EVENT_CODE(LPC_WRITE, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_RPC(RPC_REPLICATION_CLIENT_READ, TASK_PRIORITY_COMMON)
#undef CURRENT_THREAD_POOL

// THREAD_POOL_REPLICATION_LONG
#define CURRENT_THREAD_POOL THREAD_POOL_REPLICATION_LONG
MAKE_EVENT_CODE(LPC_LEARN_REMOTE_DELTA_FILES, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE_AIO(LPC_REPLICATION_COPY_REMOTE_FILES, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_GARBAGE_COLLECT_LOGS_AND_REPLICAS, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_OPEN_REPLICA, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_CLOSE_REPLICA, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_CHECKPOINT_REPLICA, TASK_PRIORITY_COMMON)
MAKE_EVENT_CODE(LPC_CATCHUP_WITH_PRIVATE_LOGS, TASK_PRIORITY_COMMON)
#undef CURRENT_THREAD_POOL

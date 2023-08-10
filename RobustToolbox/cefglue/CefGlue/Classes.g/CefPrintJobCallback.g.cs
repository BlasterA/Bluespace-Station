﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefPrintJobCallback : IDisposable
    {
        internal static CefPrintJobCallback FromNative(cef_print_job_callback_t* ptr)
        {
            return new CefPrintJobCallback(ptr);
        }
        
        internal static CefPrintJobCallback FromNativeOrNull(cef_print_job_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefPrintJobCallback(ptr);
        }
        
        private cef_print_job_callback_t* _self;
        
        private CefPrintJobCallback(cef_print_job_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefPrintJobCallback()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_print_job_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_print_job_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_print_job_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal bool HasAtLeastOneRef
        {
            get { return cef_print_job_callback_t.has_at_least_one_ref(_self) != 0; }
        }
        
        internal cef_print_job_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}

// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Rendering
// Classes: 55
// Methods: 679

namespace ThirdParty.Unity.UnityEngine.Rendering
{
    public class AsyncGPUReadback : Object
    {
        // ── Methods ──
        public void ValidateFormat(){} // RVA: 0x7AEF2D9D0
        public void WaitAllRequests(){} // RVA: 0x7AEF2DB60
        public void Request(){} // RVA: 0x7AEF2E1F0
        public void Request_Internal_Texture_1(){} // RVA: 0x7AEF2E360
        public void Request_Internal_Texture_2(){} // RVA: 0x7AEF2E3F0
        public void Request_Internal_Texture_3(){} // RVA: 0x7AEF2E480
        public void Request_Internal_Texture_4(){} // RVA: 0x7AEF2E550
        public void Request_Internal_Texture_1_Injected(){} // RVA: 0x7AEF2E630
        public void Request_Internal_Texture_2_Injected(){} // RVA: 0x7AEF2E6B0
        public void Request_Internal_Texture_3_Injected(){} // RVA: 0x7AEF2E730
        public void Request_Internal_Texture_4_Injected(){} // RVA: 0x7AEF2E7B0
    }

    public class AsyncGPUReadbackRequest : ValueType
    {
        // ── Methods ──
        public void GetData(){} // RVA: 0x7A8051B10
        public void get_done(){} // RVA: 0x7A7EE09B0
        public void get_hasError(){} // RVA: 0x7A7EE0A00
        public void get_layerCount(){} // RVA: 0x7A7EE0A50
        public void get_layerDataSize(){} // RVA: 0x7A7EE0AA0
        public void get_width(){} // RVA: 0x7A7EE0AF0
        public void get_height(){} // RVA: 0x7A7EE0B40
        public void get_depth(){} // RVA: 0x7A7EE0B90
        public void IsDone(){} // RVA: 0x7A7EE09B0
        public void HasError(){} // RVA: 0x7A7EE0A00
        public void GetLayerCount(){} // RVA: 0x7A7EE0A50
        public void GetLayerDataSize(){} // RVA: 0x7A7EE0AA0
        public void GetWidth(){} // RVA: 0x7A7EE0AF0
        public void GetHeight(){} // RVA: 0x7A7EE0B40
        public void GetDepth(){} // RVA: 0x7A7EE0B90
        public void SetScriptingCallback(){} // RVA: 0x7A7EE0BE0
        public void GetDataRaw(){} // RVA: 0x7A7EE0BF0
        public void IsDone_Injected(){} // RVA: 0x7AEF2D6E0
        public void HasError_Injected(){} // RVA: 0x7AEF2D730
        public void GetLayerCount_Injected(){} // RVA: 0x7AEF2D780
        public void GetLayerDataSize_Injected(){} // RVA: 0x7AEF2D7D0
        public void GetWidth_Injected(){} // RVA: 0x7AEF2D820
        public void GetHeight_Injected(){} // RVA: 0x7AEF2D870
        public void GetDepth_Injected(){} // RVA: 0x7AEF2D8C0
        public void SetScriptingCallback_Injected(){} // RVA: 0x7AEF2D910
        public void GetDataRaw_Injected(){} // RVA: 0x7AEF2D970
    }

    public class AsyncGPUReadbackRequest[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class AsyncRequestNativeArrayData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BatchCullingContext : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EE1450
    }

    public class BatchCullingContext[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BatchID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7EDA7E0
        public void .cctor(){} // RVA: 0x7AEF37260
    }

    public class BatchID[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BatchMaterialID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7EDA7E0
        public void .cctor(){} // RVA: 0x7AEF37340
    }

    public class BatchMaterialID[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BatchMeshID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void Equals(){} // RVA: 0x7A7EDA7E0
        public void .cctor(){} // RVA: 0x7AEF37420
    }

    public class BatchMeshID[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BatchPackedCullingViewID : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7A7EE13B0
        public void Equals(){} // RVA: 0x7A7EE13C0
    }

    public class BatchRendererCullingOutput[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BatchRendererGroup : Object
    {
        // ── Methods ──
        public void InvokeOnPerformCulling(){} // RVA: 0x7AEF375B0
    }

    public class BatchRendererGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CameraEventUtils : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7AEF2E840
    }

    public class CameraProperties : ValueType
    {
        // ── Methods ──
        public void GetShadowCullingPlane(){} // RVA: 0x7A7EE1F10
        public void GetCameraCullingPlane(){} // RVA: 0x7A7EE1F40
        public void Equals(){} // RVA: 0x7A7EE2020
        public void GetHashCode(){} // RVA: 0x7A7EE2160
    }

    public class CameraProperties[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CommandBuffer : Object
    {
        // ── Methods ──
        public void WaitAllAsyncReadbackRequests(){} // RVA: 0x7AEF2FED0
        public void RequestAsyncReadback(){} // RVA: 0x7AEF30250
        public void Internal_RequestAsyncReadback_1(){} // RVA: 0x7AEF30330
        public void Internal_RequestAsyncReadback_4(){} // RVA: 0x7AEF303B0
        public void Internal_RequestAsyncReadback_5(){} // RVA: 0x7AEF30440
        public void Internal_RequestAsyncReadback_6(){} // RVA: 0x7AEF304D0
        public void Internal_RequestAsyncReadback_8(){} // RVA: 0x7AEF30560
        public void Internal_SetSinglePassStereo(){} // RVA: 0x7AEF305E0
        public void InitBuffer(){} // RVA: 0x7AEF30640
        public void WaitOnGPUFence_Internal(){} // RVA: 0x7AEF30690
        public void ReleaseBuffer(){} // RVA: 0x7AEF30700
        public void SetComputeFloatParam(){} // RVA: 0x7AEF334D0
        public void SetComputeIntParam(){} // RVA: 0x7AEF33590
        public void SetComputeVectorParam(){} // RVA: 0x7AEF33620
        public void Internal_SetComputeFloats(){} // RVA: 0x7AEF308D0
        public void Internal_SetComputeTextureParam(){} // RVA: 0x7AEF30950
        public void Internal_SetComputeBufferParam(){} // RVA: 0x7AEF309E0
        public void Internal_SetComputeGraphicsBufferParam(){} // RVA: 0x7AEF30A70
        public void Internal_DispatchCompute(){} // RVA: 0x7AEF30B00
        public void set_name(){} // RVA: 0x7AEF30B90
        public void Clear(){} // RVA: 0x7AEF30BF0
        public void Internal_DrawMesh(){} // RVA: 0x7AEF30C40
        public void Internal_DrawRenderer(){} // RVA: 0x7AEF30CE0
        public void Internal_DrawMeshInstancedIndirectGraphicsBuffer(){} // RVA: 0x7AEF30D70
        public void SetViewport(){} // RVA: 0x7AEF30E00
        public void CopyTexture_Internal(){} // RVA: 0x7AEF30E60
        public void Blit_Texture(){} // RVA: 0x7AEF30EF0
        public void Blit_Identifier(){} // RVA: 0x7AEF30FB0
        public void GetTemporaryRT(){} // RVA: 0x7AEF317D0
        public void GetTemporaryRTWithDescriptor(){} // RVA: 0x7AEF316B0
        public void ReleaseTemporaryRT(){} // RVA: 0x7AEF31860
        public void ClearRenderTarget(){} // RVA: 0x7AEF31950
        public void SetGlobalFloat(){} // RVA: 0x7AEF31A50
        public void SetGlobalInteger(){} // RVA: 0x7AEF31AC0
        public void SetGlobalVector(){} // RVA: 0x7AEF31B30
        public void SetGlobalColor(){} // RVA: 0x7AEF31BA0
        public void EnableShaderKeyword(){} // RVA: 0x7AEF31C10
        public void DisableShaderKeyword(){} // RVA: 0x7AEF31C70
        public void SetViewProjectionMatrices(){} // RVA: 0x7AEF31CD0
        public void SetExecutionFlags(){} // RVA: 0x7AEF31D40
        public void ValidateAgainstExecutionFlags(){} // RVA: 0x7AEF31DA0
        public void SetGlobalTexture_Impl(){} // RVA: 0x7AEF31E10
        public void SetGlobalGraphicsBufferInternal(){} // RVA: 0x7AEF31E90
        public void BeginSample(){} // RVA: 0x7AEF31F00
        public void EndSample(){} // RVA: 0x7AEF31F60
        public void IssuePluginEventAndDataInternal(){} // RVA: 0x7AEF31FC0
        public void SetRenderTarget(){} // RVA: 0x7AEF32AC0
        public void SetRenderTargetSingle_Internal(){} // RVA: 0x7AEF32D50
        public void SetRenderTargetColorDepth_Internal(){} // RVA: 0x7AEF32DF0
        public void SetRenderTargetMulti_Internal(){} // RVA: 0x7AEF32EA0
        public void Finalize(){} // RVA: 0x7AEF32F50
        public void Dispose(){} // RVA: 0x7AEF33080
        public void .ctor(){} // RVA: 0x7AEF330E0
        public void Release(){} // RVA: 0x7AEF33130
        public void WaitOnAsyncGraphicsFence(){} // RVA: 0x7AEF333F0
        public void SetComputeFloatParams(){} // RVA: 0x7AEF336F0
        public void SetComputeTextureParam(){} // RVA: 0x7AEF33930
        public void SetComputeBufferParam(){} // RVA: 0x7AEF30A70
        public void DispatchCompute(){} // RVA: 0x7AEF30B00
        public void DrawMesh(){} // RVA: 0x7AEF33F30
        public void DrawRenderer(){} // RVA: 0x7AEF34340
        public void DrawMeshInstancedIndirect(){} // RVA: 0x7AEF347E0
        public void CopyTexture(){} // RVA: 0x7AEF348F0
        public void Blit(){} // RVA: 0x7AEF34D50
        public void SetGlobalTexture(){} // RVA: 0x7AEF34F80
        public void SetGlobalBuffer(){} // RVA: 0x7AEF31E90
        public void SetSinglePassStereo(){} // RVA: 0x7AEF305E0
        public void IssuePluginEventAndData(){} // RVA: 0x7AEF34FA0
        public void SetComputeVectorParam_Injected(){} // RVA: 0x7AEF350C0
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7AEF35140
        public void SetViewport_Injected(){} // RVA: 0x7AEF351D0
        public void Blit_Texture_Injected(){} // RVA: 0x7AEF35230
        public void Blit_Identifier_Injected(){} // RVA: 0x7AEF352C0
        public void GetTemporaryRTWithDescriptor_Injected(){} // RVA: 0x7AEF35350
        public void ClearRenderTarget_Injected(){} // RVA: 0x7AEF353D0
        public void SetGlobalVector_Injected(){} // RVA: 0x7AEF35450
        public void SetGlobalColor_Injected(){} // RVA: 0x7AEF354C0
        public void SetViewProjectionMatrices_Injected(){} // RVA: 0x7AEF35530
        public void SetRenderTargetSingle_Internal_Injected(){} // RVA: 0x7AEF355A0
        public void SetRenderTargetColorDepth_Internal_Injected(){} // RVA: 0x7AEF35630
        public void SetRenderTargetMulti_Internal_Injected(){} // RVA: 0x7AEF356C0
    }

    public class CommandBuffer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CoreCameraValues : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7EE1E30
        public void GetHashCode(){} // RVA: 0x7A7EE1EF0
    }

    public class CoreCameraValues[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class CullingSplit[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A40C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29ED50
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4690
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25DB30
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29ED50
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GraphicsDeviceType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D3F10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6990
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA281BF0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GraphicsFence : ValueType
    {
        // ── Methods ──
        public void TranslateSynchronizationStageToFlags(){} // RVA: 0x7AEF2F810
        public void InitPostAllocation(){} // RVA: 0x7A7EE0EF0
        public void IsFencePending(){} // RVA: 0x7A7EE0F00
        public void Validate(){} // RVA: 0x7A7EE0F10
        public void GetPlatformNotSupportedVersion(){} // RVA: 0x7A7EE0F20
        public void GetVersionNumber(){} // RVA: 0x7AEF2FA60
    }

    public class GraphicsFence[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GraphicsSettings : Object
    {
        // ── Methods ──
        public void get_lightsUseLinearIntensity(){} // RVA: 0x7AEF2FAB0
        public void get_defaultRenderingLayerMask(){} // RVA: 0x7AEF2FB00
        public void get_INTERNAL_currentRenderPipeline(){} // RVA: 0x7AEF2FB50
        public void get_currentRenderPipeline(){} // RVA: 0x7AEF2FBA0
        public void get_INTERNAL_defaultRenderPipeline(){} // RVA: 0x7AEF2FC50
        public void get_defaultRenderPipeline(){} // RVA: 0x7AEF2FCA0
        public void GetShaderMode(){} // RVA: 0x7AEF2FD50
    }

    public class LODParameters : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7EE2AB0
        public void GetHashCode(){} // RVA: 0x7A7EE2B60
    }

    public class LocalKeyword : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A7E42C20
        public void Equals(){} // RVA: 0x7A7EE31A0
        public void GetHashCode(){} // RVA: 0x7A7EE31F0
    }

    public class LocalKeywordSpace : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7A393B0
        public void op_Equality(){} // RVA: 0x7AEF3E3D0
        public void GetHashCode(){} // RVA: 0x7A79EAED0
    }

    public class LocalKeyword[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D51C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2C90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2828C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DF80
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ObjectIdRequest : Object
    {
        // ── Methods ──
        public void get_destination(){} // RVA: 0x7A80F2570
    }

    public class OnDemandRendering : Object
    {
        // ── Methods ──
        public void get_renderFrameInterval(){} // RVA: 0x7AEF2FDA0
        public void GetRenderFrameInterval(){} // RVA: 0x7AEF2FE00
        public void .cctor(){} // RVA: 0x7AEF2FE90
    }

    public class OnDemandRendering[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ReflectionProbeBlendInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A1530
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA250600
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RenderPipeline : Object
    {
        // ── Methods ──
        public void Render(){} // RVA: 0x7AEF3B010
        public void ProcessRenderRequests(){} // RVA: 0x7A8051B10
        public void IsRenderRequestSupported(){} // RVA: 0x7A8051B10
        public void InternalRender(){} // RVA: 0x7AEF3B090
        public void InternalProcessRenderRequests(){} // RVA: 0x7A8051B10
        public void get_disposed(){} // RVA: 0x7A81A2200
        public void set_disposed(){} // RVA: 0x7A81A2210
        public void Dispose(){} // RVA: 0x7A80D7310
    }

    public class RenderPipelineAsset : ScriptableObject
    {
        // ── Methods ──
        public void InternalCreatePipeline(){} // RVA: 0x7AEF3B190
        public void get_renderingLayerMaskNames(){} // RVA: 0x7A82D1450
        public void get_prefixedRenderingLayerMaskNames(){} // RVA: 0x7A82D1450
        public void get_defaultMaterial(){} // RVA: 0x7A82D1450
        public void get_autodeskInteractiveShader(){} // RVA: 0x7A82D1450
        public void get_autodeskInteractiveTransparentShader(){} // RVA: 0x7A82D1450
        public void get_autodeskInteractiveMaskedShader(){} // RVA: 0x7A82D1450
        public void get_terrainDetailLitShader(){} // RVA: 0x7A82D1450
        public void get_terrainDetailGrassShader(){} // RVA: 0x7A82D1450
        public void get_terrainDetailGrassBillboardShader(){} // RVA: 0x7A82D1450
        public void get_defaultParticleMaterial(){} // RVA: 0x7A82D1450
        public void get_defaultLineMaterial(){} // RVA: 0x7A82D1450
        public void get_defaultTerrainMaterial(){} // RVA: 0x7A82D1450
        public void get_defaultUIMaterial(){} // RVA: 0x7A82D1450
        public void get_defaultUIOverdrawMaterial(){} // RVA: 0x7A82D1450
        public void get_defaultUIETC1SupportedMaterial(){} // RVA: 0x7A82D1450
        public void get_default2DMaterial(){} // RVA: 0x7A82D1450
        public void get_default2DMaskMaterial(){} // RVA: 0x7A82D1450
        public void get_defaultShader(){} // RVA: 0x7A82D1450
        public void get_defaultSpeedTree7Shader(){} // RVA: 0x7A82D1450
        public void get_defaultSpeedTree8Shader(){} // RVA: 0x7A82D1450
        public void get_renderPipelineShaderTag(){} // RVA: 0x7AEF3B370
        public void CreatePipeline(){} // RVA: 0x7A7E00680
        public void OnValidate(){} // RVA: 0x7AEF3B3B0
        public void OnDisable(){} // RVA: 0x7AEF3B520
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class RenderPipelineManager : Object
    {
        // ── Methods ──
        public void get_currentPipeline(){} // RVA: 0x7AEF3B570
        public void set_currentPipeline(){} // RVA: 0x7AEF3B5D0
        public void add_beginCameraRendering(){} // RVA: 0x7AEF3B760
        public void remove_beginCameraRendering(){} // RVA: 0x7AEF3B8D0
        public void add_endCameraRendering(){} // RVA: 0x7AEF3BA40
        public void remove_endCameraRendering(){} // RVA: 0x7AEF3BBB0
        public void OnActiveRenderPipelineTypeChanged(){} // RVA: 0x7AEF3BD20
        public void OnActiveRenderPipelineAssetChanged(){} // RVA: 0x7AEF3BD90
        public void HandleRenderPipelineChange(){} // RVA: 0x7AEF3BEA0
        public void CleanupRenderPipeline(){} // RVA: 0x7AEF3BF80
        public void GetCurrentPipelineAssetType(){} // RVA: 0x7AEF3C260
        public void DoRenderLoop_Internal(){} // RVA: 0x7AEF3C2C0
        public void PrepareRenderPipeline(){} // RVA: 0x7AEF3C770
        public void IsPipelineRequireCreation(){} // RVA: 0x7AEF3CA20
        public void .cctor(){} // RVA: 0x7AEF3CB80
    }

    public class RenderPipelineManager[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RenderTargetIdentifier : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EE0DD0
        public void op_Implicit(){} // RVA: 0x7AEF2F2C0
        public void ToString(){} // RVA: 0x7A7EE0E00
        public void GetHashCode(){} // RVA: 0x7A7EE0E10
        public void Equals(){} // RVA: 0x7A7EE0EC0
    }

    public class RenderTargetIdentifier[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D7980
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E31C0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA284340
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E250
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ScriptableCullingParameters : ValueType
    {
        // ── Methods ──
        public void get_cullingPlaneCount(){} // RVA: 0x7A7EE28F0
        public void GetLayerCullingDistance(){} // RVA: 0x7A7EE2900
        public void GetCullingPlane(){} // RVA: 0x7A7EE2910
        public void Equals(){} // RVA: 0x7A7EE2990
        public void GetHashCode(){} // RVA: 0x7A7EE2A60
        public void .cctor(){} // RVA: 0x7AEF3AD70
    }

    public class ScriptableCullingParameters[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7A80804D0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ScriptableRenderContext : ValueType
    {
        // ── Methods ──
        public void GetCameras_Internal(){} // RVA: 0x7A7EE2B70
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void GetCameras(){} // RVA: 0x7A7EE2B80
        public void Equals(){} // RVA: 0x7A7EE2BA0
        public void GetHashCode(){} // RVA: 0x7A79EAED0
        public void .cctor(){} // RVA: 0x7AEF3D060
        public void GetCameras_Internal_Injected(){} // RVA: 0x7AEF3D100
    }

    public class ShaderTagId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EE2C50
        public void Equals(){} // RVA: 0x7A7EDA7E0
        public void GetHashCode(){} // RVA: 0x7A7EE2D30
    }

    public class SortingGroup : Behaviour
    {
        // ── Methods ──
        public void get_invalidSortingGroupID(){} // RVA: 0x7AEF3E3E0
        public void UpdateAllSortingGroups(){} // RVA: 0x7AEF3E430
        public void GetSortingGroupByIndex(){} // RVA: 0x7AEF3E480
        public void get_sortingLayerName(){} // RVA: 0x7AEF3E4D0
        public void set_sortingLayerName(){} // RVA: 0x7AEF3E520
        public void get_sortingLayerID(){} // RVA: 0x7AEF3E580
        public void set_sortingLayerID(){} // RVA: 0x7AEF3E5D0
        public void get_sortingOrder(){} // RVA: 0x7AEF3E630
        public void set_sortingOrder(){} // RVA: 0x7AEF3E680
        public void get_sortAtRoot(){} // RVA: 0x7AEF3E6E0
        public void set_sortAtRoot(){} // RVA: 0x7AEF3E730
        public void get_sortingGroupID(){} // RVA: 0x7AEF3E790
        public void get_sortingGroupOrder(){} // RVA: 0x7AEF3E7E0
        public void get_index(){} // RVA: 0x7AEF3E830
        public void get_sortingKey(){} // RVA: 0x7AEF3E880
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class SphericalHarmonicsL2 : ValueType
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7A7EE0F30
        public void SetZero(){} // RVA: 0x7A7EE0F30
        public void AddAmbientLight(){} // RVA: 0x7A7EE0F80
        public void AddDirectionalLight(){} // RVA: 0x7A7EE0FE0
        public void AddDirectionalLightInternal(){} // RVA: 0x7AEF358E0
        public void Evaluate(){} // RVA: 0x7A7EE10C0
        public void EvaluateInternal(){} // RVA: 0x7AEF35AC0
        public void get_Item(){} // RVA: 0x7A7EE10D0
        public void set_Item(){} // RVA: 0x7A7EE10E0
        public void GetHashCode(){} // RVA: 0x7A7EE10F0
        public void Equals(){} // RVA: 0x7A7EE1110
        public void op_Multiply(){} // RVA: 0x7AEF367C0
        public void op_Addition(){} // RVA: 0x7AEF36AD0
        public void op_Equality(){} // RVA: 0x7AEF36E10
        public void op_Inequality(){} // RVA: 0x7AEF37030
        public void SetZero_Injected(){} // RVA: 0x7AEF35750
        public void AddAmbientLight_Injected(){} // RVA: 0x7AEF370F0
        public void AddDirectionalLightInternal_Injected(){} // RVA: 0x7AEF37150
    }

    public class SphericalHarmonicsL2[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D9010
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29FE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6FE0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA285280
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29FE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class StencilState : ValueType
    {
        // ── Methods ──
        public void set_enabled(){} // RVA: 0x7A7EE2D40
        public void set_readMask(){} // RVA: 0x7A763C970
        public void set_writeMask(){} // RVA: 0x7A763C9C0
        public void set_compareFunctionFront(){} // RVA: 0x7A763C9A0
        public void set_passOperationFront(){} // RVA: 0x7A763C9D0
        public void set_failOperationFront(){} // RVA: 0x7A763C940
        public void set_zFailOperationFront(){} // RVA: 0x7A7EE2DA0
        public void set_compareFunctionBack(){} // RVA: 0x7A7664CA0
        public void set_passOperationBack(){} // RVA: 0x7A7664BE0
        public void set_failOperationBack(){} // RVA: 0x7A7EE2DB0
        public void set_zFailOperationBack(){} // RVA: 0x7A7EE2DC0
        public void Equals(){} // RVA: 0x7A7EE2EA0
        public void GetHashCode(){} // RVA: 0x7A7EE3000
    }

    public class SubMeshDescriptor : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EE0C50
        public void get_bounds(){} // RVA: 0x7A76A6DB0
        public void set_bounds(){} // RVA: 0x7A7712B90
        public void get_topology(){} // RVA: 0x7A768A430
        public void set_topology(){} // RVA: 0x7A768A440
        public void get_indexStart(){} // RVA: 0x7A768B130
        public void set_indexStart(){} // RVA: 0x7A768B140
        public void get_indexCount(){} // RVA: 0x7A767FF50
        public void set_indexCount(){} // RVA: 0x7A767FF30
        public void get_baseVertex(){} // RVA: 0x7A76C73F0
        public void set_baseVertex(){} // RVA: 0x7A76C73E0
        public void get_firstVertex(){} // RVA: 0x7A765EE70
        public void set_firstVertex(){} // RVA: 0x7A765EDE0
        public void get_vertexCount(){} // RVA: 0x7A77197A0
        public void set_vertexCount(){} // RVA: 0x7A7719790
        public void ToString(){} // RVA: 0x7A7EE0C90
    }

    public class SupportedRenderingFeatures : Object
    {
        // ── Methods ──
        public void get_active(){} // RVA: 0x7AEF3D550
        public void set_active(){} // RVA: 0x7AEF3D670
        public void get_defaultMixedLightingModes(){} // RVA: 0x7A8668BC0
        public void get_mixedLightingModes(){} // RVA: 0x7A83782A0
        public void get_lightmapBakeTypes(){} // RVA: 0x7A9739200
        public void get_lightmapsModes(){} // RVA: 0x7A851DB90
        public void get_enlightenLightmapper(){} // RVA: 0x7A80F29B0
        public void get_enlighten(){} // RVA: 0x7A92AA5C0
        public void get_rendersUIOverlay(){} // RVA: 0x7A81B7080
        public void get_autoAmbientProbeBaking(){} // RVA: 0x7A9A79980
        public void get_autoDefaultReflectionProbeBaking(){} // RVA: 0x7A82A20A0
        public void get_overridesLightProbeSystem(){} // RVA: 0x7A9286CF0
        public void FallbackMixedLightingModeByRef(){} // RVA: 0x7AEF3D720
        public void IsMixedLightingModeSupported(){} // RVA: 0x7AEF3D950
        public void IsMixedLightingModeSupportedByRef(){} // RVA: 0x7AEF3DAC0
        public void IsLightmapBakeTypeSupported(){} // RVA: 0x7AEF3DC20
        public void IsLightmapBakeTypeSupportedByRef(){} // RVA: 0x7AEF3DD50
        public void IsLightmapsModeSupportedByRef(){} // RVA: 0x7AEF3DE50
        public void IsLightmapperSupportedByRef(){} // RVA: 0x7AEF3DEC0
        public void IsUIOverlayRenderedBySRP(){} // RVA: 0x7AEF3DF40
        public void IsAutoAmbientProbeBakingSupported(){} // RVA: 0x7AEF3DFA0
        public void IsAutoDefaultReflectionProbeBakingSupported(){} // RVA: 0x7AEF3E000
        public void OverridesLightProbeSystem(){} // RVA: 0x7AEF3E060
        public void FallbackLightmapperByRef(){} // RVA: 0x7A9CE24F0
        public void .ctor(){} // RVA: 0x7AEF3E0C0
        public void .cctor(){} // RVA: 0x7AEF3E190
    }

    public class SupportedRenderingFeatures[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VertexAttributeDescriptor : ValueType
    {
        // ── Methods ──
        public void get_attribute(){} // RVA: 0x7A765F070
        public void set_attribute(){} // RVA: 0x7A76134D0
        public void get_format(){} // RVA: 0x7A765F0A0
        public void set_format(){} // RVA: 0x7A765F090
        public void get_dimension(){} // RVA: 0x7A75FEFA0
        public void set_dimension(){} // RVA: 0x7A767FBC0
        public void get_stream(){} // RVA: 0x7A767FBD0
        public void set_stream(){} // RVA: 0x7A767FBE0
        public void .ctor(){} // RVA: 0x7A7E2BDA0
        public void ToString(){} // RVA: 0x7A7EE0CA0
        public void GetHashCode(){} // RVA: 0x7A7EE0CB0
        public void Equals(){} // RVA: 0x7A7EE0CE0
    }

    public class VertexAttributeDescriptor[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2DDC90
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E2920
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA299FA0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DD90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}
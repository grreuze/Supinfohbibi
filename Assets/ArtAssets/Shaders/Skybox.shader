// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:2,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33599,y:32658,varname:node_3138,prsc:2|emission-2651-OUT,custl-2651-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:5617,x:31122,y:32895,varname:node_5617,prsc:2;n:type:ShaderForge.SFN_ComponentMask,id:9248,x:31958,y:32940,varname:node_9248,prsc:2,cc1:1,cc2:-1,cc3:-1,cc4:-1|IN-5858-OUT;n:type:ShaderForge.SFN_Color,id:4730,x:31299,y:32374,ptovrint:False,ptlb:Color_Top,ptin:_Color_Top,varname:node_4730,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Color,id:8878,x:31542,y:32549,ptovrint:False,ptlb:Color_Bot,ptin:_Color_Bot,varname:_node_4730_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Normalize,id:5858,x:31652,y:32936,varname:node_5858,prsc:2|IN-5617-XYZ;n:type:ShaderForge.SFN_Lerp,id:3037,x:32470,y:32810,varname:node_3037,prsc:2|A-8878-RGB,B-4730-RGB,T-195-OUT;n:type:ShaderForge.SFN_Slider,id:105,x:31464,y:32773,ptovrint:False,ptlb:Remap_SKybox,ptin:_Remap_SKybox,varname:node_105,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4627253,max:1;n:type:ShaderForge.SFN_RemapRange,id:409,x:31958,y:32771,varname:node_409,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-105-OUT;n:type:ShaderForge.SFN_Add,id:195,x:32170,y:32880,varname:node_195,prsc:2|A-409-OUT,B-9248-OUT;n:type:ShaderForge.SFN_Add,id:7584,x:33124,y:32761,varname:node_7584,prsc:2|A-7358-RGB,B-3037-OUT;n:type:ShaderForge.SFN_Tex2d,id:7358,x:33151,y:32311,ptovrint:False,ptlb:Texture_Cloud,ptin:_Texture_Cloud,varname:node_7358,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-4658-OUT;n:type:ShaderForge.SFN_TexCoord,id:7889,x:31626,y:32242,varname:node_7889,prsc:2,uv:0;n:type:ShaderForge.SFN_Append,id:5991,x:32227,y:32353,varname:node_5991,prsc:2|A-2503-OUT,B-215-OUT;n:type:ShaderForge.SFN_Multiply,id:215,x:32027,y:32152,varname:node_215,prsc:2|A-7889-U,B-7070-OUT;n:type:ShaderForge.SFN_Slider,id:7070,x:31677,y:32169,ptovrint:False,ptlb:U_remap,ptin:_U_remap,varname:node_7070,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Time,id:6599,x:32241,y:31938,varname:node_6599,prsc:2;n:type:ShaderForge.SFN_Vector2,id:9741,x:32227,y:32170,varname:node_9741,prsc:2,v1:0,v2:1;n:type:ShaderForge.SFN_Slider,id:9783,x:32180,y:32087,ptovrint:False,ptlb:V_Vitesse,ptin:_V_Vitesse,varname:node_9783,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:0.1;n:type:ShaderForge.SFN_Add,id:4658,x:32864,y:32302,varname:node_4658,prsc:2|A-6866-OUT,B-5991-OUT,C-980-OUT;n:type:ShaderForge.SFN_Multiply,id:6866,x:32535,y:32064,varname:node_6866,prsc:2|A-6599-T,B-9783-OUT,C-9741-OUT;n:type:ShaderForge.SFN_Cubemap,id:8025,x:32865,y:33029,ptovrint:False,ptlb:Texture_Cubemap,ptin:_Texture_Cubemap,varname:node_8025,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,pvfc:0;n:type:ShaderForge.SFN_Add,id:2651,x:33372,y:32829,varname:node_2651,prsc:2|A-8025-RGB,B-7584-OUT;n:type:ShaderForge.SFN_Slider,id:6274,x:31675,y:32443,ptovrint:False,ptlb:V_Remap,ptin:_V_Remap,varname:node_6274,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.05145212,max:1;n:type:ShaderForge.SFN_Multiply,id:2503,x:32088,y:32502,varname:node_2503,prsc:2|A-7889-V,B-6274-OUT;n:type:ShaderForge.SFN_Slider,id:5132,x:32162,y:31854,ptovrint:False,ptlb:U_Vitesse,ptin:_U_Vitesse,varname:node_5132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:0.1;n:type:ShaderForge.SFN_Multiply,id:980,x:32582,y:31851,varname:node_980,prsc:2|A-5132-OUT,B-6599-T,C-3787-OUT;n:type:ShaderForge.SFN_Vector2,id:3787,x:32453,y:31984,varname:node_3787,prsc:2,v1:1,v2:0;proporder:4730-8878-7358-8025-105-7070-5132-6274-9783;pass:END;sub:END;*/

Shader "Shader Forge/NewShader" {
    Properties {
        _Color_Top ("Color_Top", Color) = (0,1,1,1)
        _Color_Bot ("Color_Bot", Color) = (1,0,0,1)
        _Texture_Cloud ("Texture_Cloud", 2D) = "white" {}
        _Texture_Cubemap ("Texture_Cubemap", Cube) = "_Skybox" {}
        _Remap_SKybox ("Remap_SKybox", Range(0, 1)) = 0.4627253
        _U_remap ("U_remap", Range(0, 1)) = 0
        _U_Vitesse ("U_Vitesse", Range(0, 0.1)) = 0
        _V_Remap ("V_Remap", Range(0, 1)) = 0.05145212
        _V_Vitesse ("V_Vitesse", Range(0, 0.1)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
            "PreviewType"="Skybox"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float4 _Color_Top;
            uniform float4 _Color_Bot;
            uniform float _Remap_SKybox;
            uniform sampler2D _Texture_Cloud; uniform float4 _Texture_Cloud_ST;
            uniform float _U_remap;
            uniform float _V_Vitesse;
            uniform samplerCUBE _Texture_Cubemap;
            uniform float _V_Remap;
            uniform float _U_Vitesse;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
////// Lighting:
////// Emissive:
                float4 node_6599 = _Time + _TimeEditor;
                float2 node_4658 = ((node_6599.g*_V_Vitesse*float2(0,1))+float2((i.uv0.g*_V_Remap),(i.uv0.r*_U_remap))+(_U_Vitesse*node_6599.g*float2(1,0)));
                float4 _Texture_Cloud_var = tex2D(_Texture_Cloud,TRANSFORM_TEX(node_4658, _Texture_Cloud));
                float3 node_2651 = (texCUBE(_Texture_Cubemap,viewReflectDirection).rgb+(_Texture_Cloud_var.rgb+lerp(_Color_Bot.rgb,_Color_Top.rgb,((_Remap_SKybox*2.0+-1.0)+normalize(i.posWorld.rgb).g))));
                float3 emissive = node_2651;
                float3 finalColor = emissive + node_2651;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

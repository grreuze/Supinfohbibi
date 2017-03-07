// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.32 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.32;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:2,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:True,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:33785,y:32636,varname:node_3138,prsc:2|normal-2078-OUT,emission-7186-OUT,custl-5205-OUT,voffset-6615-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31494,y:31614,ptovrint:False,ptlb:Color1,ptin:_Color1,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_ComponentMask,id:7309,x:31401,y:33775,varname:node_7309,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-6244-XYZ;n:type:ShaderForge.SFN_Sin,id:2372,x:32028,y:33761,varname:node_2372,prsc:2|IN-8391-OUT;n:type:ShaderForge.SFN_Multiply,id:8391,x:31819,y:33761,varname:node_8391,prsc:2|A-5711-OUT,B-3703-OUT;n:type:ShaderForge.SFN_Slider,id:3703,x:31604,y:33666,ptovrint:False,ptlb:Wave_Quantity_U,ptin:_Wave_Quantity_U,varname:node_571,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5.128204,max:100;n:type:ShaderForge.SFN_ComponentMask,id:1668,x:31407,y:34063,varname:node_1668,prsc:2,cc1:2,cc2:-1,cc3:-1,cc4:-1|IN-6244-XYZ;n:type:ShaderForge.SFN_Multiply,id:7273,x:31794,y:34044,varname:node_7273,prsc:2|A-788-OUT,B-8183-OUT;n:type:ShaderForge.SFN_Slider,id:8183,x:31615,y:34210,ptovrint:False,ptlb:Wave_Quantity_V,ptin:_Wave_Quantity_V,varname:_Wave_Intensity_U_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0.1,cur:14.29186,max:100;n:type:ShaderForge.SFN_Sin,id:3326,x:32032,y:34044,varname:node_3326,prsc:2|IN-7273-OUT;n:type:ShaderForge.SFN_Add,id:5711,x:31604,y:33758,varname:node_5711,prsc:2|A-8945-OUT,B-7309-OUT;n:type:ShaderForge.SFN_Add,id:788,x:31615,y:34044,varname:node_788,prsc:2|A-7820-OUT,B-1668-OUT;n:type:ShaderForge.SFN_Multiply,id:7442,x:32543,y:34043,varname:node_7442,prsc:2|A-7803-OUT,B-3765-OUT,C-2642-OUT;n:type:ShaderForge.SFN_Slider,id:3765,x:32386,y:34197,ptovrint:False,ptlb:Wave_Intensity_V,ptin:_Wave_Intensity_V,varname:node_8347,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:5;n:type:ShaderForge.SFN_Slider,id:4143,x:32380,y:33678,ptovrint:False,ptlb:Wave_Intensity_U,ptin:_Wave_Intensity_U,varname:_Wave_Intensity_V_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.1,max:5;n:type:ShaderForge.SFN_Multiply,id:9921,x:32537,y:33764,varname:node_9921,prsc:2|A-988-OUT,B-4143-OUT,C-2642-OUT;n:type:ShaderForge.SFN_Add,id:6615,x:32801,y:33897,varname:node_6615,prsc:2|A-9921-OUT,B-7442-OUT;n:type:ShaderForge.SFN_Clamp01,id:7803,x:32252,y:34044,varname:node_7803,prsc:2|IN-3326-OUT;n:type:ShaderForge.SFN_Clamp01,id:988,x:32253,y:33761,varname:node_988,prsc:2|IN-2372-OUT;n:type:ShaderForge.SFN_Time,id:8487,x:29228,y:32424,varname:node_8487,prsc:2;n:type:ShaderForge.SFN_Slider,id:7823,x:30629,y:33788,ptovrint:False,ptlb:Wave_Speed_U,ptin:_Wave_Speed_U,varname:node_7823,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.253354,max:10;n:type:ShaderForge.SFN_Slider,id:3426,x:30629,y:33876,ptovrint:False,ptlb:Wave_Speed_V,ptin:_Wave_Speed_V,varname:_node_7823_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3904247,max:10;n:type:ShaderForge.SFN_Multiply,id:8945,x:31068,y:33724,varname:node_8945,prsc:2|A-8487-T,B-7823-OUT;n:type:ShaderForge.SFN_Multiply,id:7820,x:31068,y:33846,varname:node_7820,prsc:2|A-8487-T,B-3426-OUT;n:type:ShaderForge.SFN_Tex2d,id:4584,x:31494,y:32083,varname:node_4584,prsc:2,tex:b6b3451afd6a34d47824960e5373f5fc,ntxv:0,isnm:False|UVIN-2081-OUT,TEX-1126-TEX;n:type:ShaderForge.SFN_Lerp,id:6174,x:31850,y:31868,varname:node_6174,prsc:2|A-7241-RGB,B-2891-RGB,T-4584-RGB;n:type:ShaderForge.SFN_Color,id:2891,x:31494,y:31774,ptovrint:False,ptlb:Color2,ptin:_Color2,varname:_Color_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.05758001,c2:0.264015,c3:0.5220588,c4:1;n:type:ShaderForge.SFN_Rotator,id:3397,x:29231,y:32281,varname:node_3397,prsc:2|UVIN-62-UVOUT,ANG-1472-OUT;n:type:ShaderForge.SFN_Pi,id:8274,x:28697,y:32273,varname:node_8274,prsc:2;n:type:ShaderForge.SFN_Vector1,id:9474,x:28664,y:32387,varname:node_9474,prsc:2,v1:180;n:type:ShaderForge.SFN_Divide,id:5206,x:28847,y:32271,varname:node_5206,prsc:2|A-8274-OUT,B-9474-OUT;n:type:ShaderForge.SFN_Multiply,id:1472,x:29041,y:32319,varname:node_1472,prsc:2|A-5206-OUT,B-3096-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:7053,x:32023,y:31599,varname:node_7053,prsc:2;n:type:ShaderForge.SFN_Distance,id:5508,x:32250,y:31478,varname:node_5508,prsc:2|A-7053-XYZ,B-4608-XYZ;n:type:ShaderForge.SFN_Divide,id:7754,x:32453,y:31478,varname:node_7754,prsc:2|A-5508-OUT,B-7184-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7184,x:32453,y:31423,ptovrint:False,ptlb:Dist,ptin:_Dist,varname:node_7184,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:50;n:type:ShaderForge.SFN_Lerp,id:7186,x:33051,y:32012,varname:node_7186,prsc:2|A-9737-OUT,B-9927-RGB,T-2978-OUT;n:type:ShaderForge.SFN_Posterize,id:2978,x:32657,y:31478,varname:node_2978,prsc:2|IN-7754-OUT,STPS-9161-OUT;n:type:ShaderForge.SFN_ValueProperty,id:9161,x:32657,y:31423,ptovrint:False,ptlb:Posterize,ptin:_Posterize,varname:node_9161,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Multiply,id:9267,x:30283,y:32037,varname:node_9267,prsc:2|A-6306-OUT,B-8556-OUT,C-8487-T;n:type:ShaderForge.SFN_Add,id:2081,x:30451,y:31987,varname:node_2081,prsc:2|A-3397-UVOUT,B-9267-OUT;n:type:ShaderForge.SFN_Slider,id:8556,x:29867,y:32118,ptovrint:False,ptlb:DiffuseBack_Speed,ptin:_DiffuseBack_Speed,varname:node_8556,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.424354,max:1;n:type:ShaderForge.SFN_ViewPosition,id:4608,x:32023,y:31478,varname:node_4608,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:62,x:28847,y:32036,varname:node_62,prsc:2,uv:0;n:type:ShaderForge.SFN_ValueProperty,id:3096,x:28847,y:32441,ptovrint:False,ptlb:rotate,ptin:_rotate,varname:node_3096,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:1406,x:29819,y:31914,ptovrint:False,ptlb:DiffuseBack_U_Directon,ptin:_DiffuseBack_U_Directon,varname:node_1406,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:8995,x:29819,y:31998,ptovrint:False,ptlb:DiffuseBack_V_Direction,ptin:_DiffuseBack_V_Direction,varname:node_8995,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Append,id:6306,x:30063,y:31938,varname:node_6306,prsc:2|A-1406-OUT,B-8995-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:6244,x:29222,y:33096,varname:node_6244,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:2642,x:32253,y:33888,prsc:2,pt:True;n:type:ShaderForge.SFN_Color,id:9927,x:31494,y:31442,ptovrint:False,ptlb:Color_Fade,ptin:_Color_Fade,varname:node_9927,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1172414,c2:1,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:1615,x:31494,y:31934,ptovrint:False,ptlb:Color_3,ptin:_Color_3,varname:node_1615,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9264706,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_OneMinus,id:3834,x:31850,y:32106,varname:node_3834,prsc:2|IN-1370-RGB;n:type:ShaderForge.SFN_Lerp,id:9737,x:32153,y:31960,varname:node_9737,prsc:2|A-1615-RGB,B-6174-OUT,T-3834-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:1126,x:29228,y:32567,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_1126,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b6b3451afd6a34d47824960e5373f5fc,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:337,x:29228,y:32755,ptovrint:False,ptlb:Normal,ptin:_Normal,varname:node_337,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:40afaca77ec344141b2e16f2974fdbf4,ntxv:3,isnm:True;n:type:ShaderForge.SFN_ValueProperty,id:5794,x:29834,y:32315,ptovrint:False,ptlb:DiffuseFront_U_Direction,ptin:_DiffuseFront_U_Direction,varname:node_5794,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:3909,x:29834,y:32400,ptovrint:False,ptlb:DiffuseFront_V_Direction,ptin:_DiffuseFront_V_Direction,varname:node_3909,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Append,id:875,x:30060,y:32315,varname:node_875,prsc:2|A-5794-OUT,B-3909-OUT;n:type:ShaderForge.SFN_Slider,id:1634,x:29903,y:32489,ptovrint:False,ptlb:DiffuseFront_Speed,ptin:_DiffuseFront_Speed,varname:node_1634,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5132378,max:1;n:type:ShaderForge.SFN_Multiply,id:3349,x:30290,y:32410,varname:node_3349,prsc:2|A-875-OUT,B-1634-OUT,C-8487-T;n:type:ShaderForge.SFN_Add,id:437,x:30723,y:32381,varname:node_437,prsc:2|A-3397-UVOUT,B-3349-OUT;n:type:ShaderForge.SFN_Tex2d,id:1370,x:31494,y:32241,varname:node_1370,prsc:2,tex:b6b3451afd6a34d47824960e5373f5fc,ntxv:0,isnm:False|UVIN-437-OUT,TEX-1126-TEX;n:type:ShaderForge.SFN_Tex2d,id:2165,x:31494,y:32421,varname:node_2165,prsc:2,tex:40afaca77ec344141b2e16f2974fdbf4,ntxv:0,isnm:False|UVIN-2081-OUT,TEX-337-TEX;n:type:ShaderForge.SFN_Tex2d,id:7557,x:31494,y:32611,varname:node_7557,prsc:2,tex:40afaca77ec344141b2e16f2974fdbf4,ntxv:0,isnm:False|UVIN-437-OUT,TEX-337-TEX;n:type:ShaderForge.SFN_NormalVector,id:6191,x:31874,y:32724,prsc:2,pt:True;n:type:ShaderForge.SFN_LightVector,id:2942,x:31874,y:32885,varname:node_2942,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:428,x:31874,y:33024,varname:node_428,prsc:2;n:type:ShaderForge.SFN_Dot,id:8142,x:32201,y:32783,varname:node_8142,prsc:2,dt:1|A-6191-OUT,B-2942-OUT;n:type:ShaderForge.SFN_Dot,id:4369,x:32182,y:32950,varname:node_4369,prsc:2,dt:1|A-2942-OUT,B-428-OUT;n:type:ShaderForge.SFN_Multiply,id:1621,x:32916,y:32792,varname:node_1621,prsc:2|A-8142-OUT,B-821-OUT;n:type:ShaderForge.SFN_Slider,id:2142,x:31764,y:33181,ptovrint:False,ptlb:Glossiness,ptin:_Glossiness,varname:node_6417,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:1,max:12;n:type:ShaderForge.SFN_Exp,id:7940,x:32114,y:33181,varname:node_7940,prsc:2,et:0|IN-2142-OUT;n:type:ShaderForge.SFN_Power,id:9153,x:32457,y:32962,varname:node_9153,prsc:2|VAL-4369-OUT,EXP-7940-OUT;n:type:ShaderForge.SFN_Posterize,id:5205,x:33354,y:32809,varname:node_5205,prsc:2|IN-1621-OUT,STPS-8612-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8612,x:33354,y:32973,ptovrint:False,ptlb:PosterizeLigh,ptin:_PosterizeLigh,varname:node_7863,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:10;n:type:ShaderForge.SFN_Color,id:5678,x:32457,y:33104,ptovrint:False,ptlb:Glossiness_Color,ptin:_Glossiness_Color,varname:node_2337,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:821,x:32700,y:32962,varname:node_821,prsc:2|A-9153-OUT,B-5678-RGB;n:type:ShaderForge.SFN_NormalBlend,id:9234,x:32046,y:32459,varname:node_9234,prsc:2|BSE-2165-RGB,DTL-7557-RGB;n:type:ShaderForge.SFN_Tex2d,id:4162,x:31225,y:33284,varname:node_3295,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-437-OUT,TEX-8870-TEX;n:type:ShaderForge.SFN_Slider,id:2536,x:31068,y:33495,ptovrint:False,ptlb:Remap,ptin:_Remap,varname:node_1045,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Add,id:5512,x:31651,y:33318,varname:node_5512,prsc:2|A-9947-OUT,B-2536-OUT;n:type:ShaderForge.SFN_RemapRange,id:699,x:31842,y:33355,varname:node_699,prsc:2,frmn:0,frmx:1,tomn:-2,tomx:1|IN-5512-OUT;n:type:ShaderForge.SFN_Tex2d,id:541,x:31236,y:33104,varname:node_9142,prsc:2,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-2081-OUT,TEX-8870-TEX;n:type:ShaderForge.SFN_Multiply,id:9947,x:31456,y:33241,varname:node_9947,prsc:2|A-4162-RGB,B-541-RGB;n:type:ShaderForge.SFN_Tex2dAsset,id:8870,x:29222,y:32940,ptovrint:False,ptlb:node_8870,ptin:_node_8870,varname:node_8870,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:7838,x:32550,y:32479,varname:node_7838,prsc:2|A-9234-OUT,B-699-OUT;n:type:ShaderForge.SFN_Negate,id:2078,x:32900,y:32549,varname:node_2078,prsc:2|IN-7838-OUT;proporder:1126-3096-7241-2891-1615-1634-8556-5794-1406-3703-4143-7823-3909-8995-8183-3765-3426-337-8870-2536-9927-7184-9161-5678-2142-8612;pass:END;sub:END;*/

Shader "Shader Forge/water" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _rotate ("rotate", Float ) = 0
        _Color1 ("Color1", Color) = (0.07843138,0.3921569,0.7843137,1)
        _Color2 ("Color2", Color) = (0.05758001,0.264015,0.5220588,1)
        _Color_3 ("Color_3", Color) = (0.9264706,0,0,1)
        _DiffuseFront_Speed ("DiffuseFront_Speed", Range(0, 1)) = 0.5132378
        _DiffuseBack_Speed ("DiffuseBack_Speed", Range(0, 1)) = 0.424354
        _DiffuseFront_U_Direction ("DiffuseFront_U_Direction", Float ) = 0
        _DiffuseBack_U_Directon ("DiffuseBack_U_Directon", Float ) = 0
        _Wave_Quantity_U ("Wave_Quantity_U", Range(0, 100)) = 5.128204
        _Wave_Intensity_U ("Wave_Intensity_U", Range(0, 5)) = 0.1
        _Wave_Speed_U ("Wave_Speed_U", Range(0, 10)) = 1.253354
        _DiffuseFront_V_Direction ("DiffuseFront_V_Direction", Float ) = 1
        _DiffuseBack_V_Direction ("DiffuseBack_V_Direction", Float ) = 1
        _Wave_Quantity_V ("Wave_Quantity_V", Range(0.1, 100)) = 14.29186
        _Wave_Intensity_V ("Wave_Intensity_V", Range(0, 5)) = 0.1
        _Wave_Speed_V ("Wave_Speed_V", Range(0, 10)) = 0.3904247
        _Normal ("Normal", 2D) = "bump" {}
        _node_8870 ("node_8870", 2D) = "white" {}
        _Remap ("Remap", Range(0, 1)) = 0
        _Color_Fade ("Color_Fade", Color) = (0.1172414,1,0,1)
        _Dist ("Dist", Float ) = 50
        _Posterize ("Posterize", Float ) = 3
        _Glossiness_Color ("Glossiness_Color", Color) = (1,0,0,1)
        _Glossiness ("Glossiness", Range(1, 12)) = 1
        _PosterizeLigh ("PosterizeLigh", Float ) = 10
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
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
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float4 _Color1;
            uniform float _Wave_Quantity_U;
            uniform float _Wave_Quantity_V;
            uniform float _Wave_Intensity_V;
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Wave_Speed_V;
            uniform float4 _Color2;
            uniform float _Dist;
            uniform float _Posterize;
            uniform float _DiffuseBack_Speed;
            uniform float _rotate;
            uniform float _DiffuseBack_U_Directon;
            uniform float _DiffuseBack_V_Direction;
            uniform float4 _Color_Fade;
            uniform float4 _Color_3;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _DiffuseFront_U_Direction;
            uniform float _DiffuseFront_V_Direction;
            uniform float _DiffuseFront_Speed;
            uniform float _Glossiness;
            uniform float _PosterizeLigh;
            uniform float4 _Glossiness_Color;
            uniform float _Remap;
            uniform sampler2D _node_8870; uniform float4 _node_8870_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_8487 = _Time + _TimeEditor;
                v.vertex.xyz += ((saturate(sin((((node_8487.g*_Wave_Speed_U)+mul(unity_ObjectToWorld, v.vertex).rgb.r)*_Wave_Quantity_U)))*_Wave_Intensity_U*v.normal)+(saturate(sin((((node_8487.g*_Wave_Speed_V)+mul(unity_ObjectToWorld, v.vertex).rgb.b)*_Wave_Quantity_V)))*_Wave_Intensity_V*v.normal));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float node_3397_ang = ((3.141592654/180.0)*_rotate);
                float node_3397_spd = 1.0;
                float node_3397_cos = cos(node_3397_spd*node_3397_ang);
                float node_3397_sin = sin(node_3397_spd*node_3397_ang);
                float2 node_3397_piv = float2(0.5,0.5);
                float2 node_3397 = (mul(i.uv0-node_3397_piv,float2x2( node_3397_cos, -node_3397_sin, node_3397_sin, node_3397_cos))+node_3397_piv);
                float4 node_8487 = _Time + _TimeEditor;
                float2 node_2081 = (node_3397+(float2(_DiffuseBack_U_Directon,_DiffuseBack_V_Direction)*_DiffuseBack_Speed*node_8487.g));
                float3 node_2165 = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_2081, _Normal)));
                float2 node_437 = (node_3397+(float2(_DiffuseFront_U_Direction,_DiffuseFront_V_Direction)*_DiffuseFront_Speed*node_8487.g));
                float3 node_7557 = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_437, _Normal)));
                float3 node_9234_nrm_base = node_2165.rgb + float3(0,0,1);
                float3 node_9234_nrm_detail = node_7557.rgb * float3(-1,-1,1);
                float3 node_9234_nrm_combined = node_9234_nrm_base*dot(node_9234_nrm_base, node_9234_nrm_detail)/node_9234_nrm_base.z - node_9234_nrm_detail;
                float3 node_9234 = node_9234_nrm_combined;
                float4 node_3295 = tex2D(_node_8870,TRANSFORM_TEX(node_437, _node_8870));
                float4 node_9142 = tex2D(_node_8870,TRANSFORM_TEX(node_2081, _node_8870));
                float3 normalLocal = (-1*(node_9234*(((node_3295.rgb*node_9142.rgb)+_Remap)*3.0+-2.0)));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
////// Emissive:
                float4 node_4584 = tex2D(_Diffuse,TRANSFORM_TEX(node_2081, _Diffuse));
                float4 node_1370 = tex2D(_Diffuse,TRANSFORM_TEX(node_437, _Diffuse));
                float3 emissive = lerp(lerp(_Color_3.rgb,lerp(_Color1.rgb,_Color2.rgb,node_4584.rgb),(1.0 - node_1370.rgb)),_Color_Fade.rgb,floor((distance(i.posWorld.rgb,_WorldSpaceCameraPos)/_Dist) * _Posterize) / (_Posterize - 1));
                float3 finalColor = emissive + floor((max(0,dot(normalDirection,lightDirection))*(pow(max(0,dot(lightDirection,viewReflectDirection)),exp(_Glossiness))*_Glossiness_Color.rgb)) * _PosterizeLigh) / (_PosterizeLigh - 1);
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float4 _Color1;
            uniform float _Wave_Quantity_U;
            uniform float _Wave_Quantity_V;
            uniform float _Wave_Intensity_V;
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Wave_Speed_V;
            uniform float4 _Color2;
            uniform float _Dist;
            uniform float _Posterize;
            uniform float _DiffuseBack_Speed;
            uniform float _rotate;
            uniform float _DiffuseBack_U_Directon;
            uniform float _DiffuseBack_V_Direction;
            uniform float4 _Color_Fade;
            uniform float4 _Color_3;
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform sampler2D _Normal; uniform float4 _Normal_ST;
            uniform float _DiffuseFront_U_Direction;
            uniform float _DiffuseFront_V_Direction;
            uniform float _DiffuseFront_Speed;
            uniform float _Glossiness;
            uniform float _PosterizeLigh;
            uniform float4 _Glossiness_Color;
            uniform float _Remap;
            uniform sampler2D _node_8870; uniform float4 _node_8870_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                LIGHTING_COORDS(5,6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_8487 = _Time + _TimeEditor;
                v.vertex.xyz += ((saturate(sin((((node_8487.g*_Wave_Speed_U)+mul(unity_ObjectToWorld, v.vertex).rgb.r)*_Wave_Quantity_U)))*_Wave_Intensity_U*v.normal)+(saturate(sin((((node_8487.g*_Wave_Speed_V)+mul(unity_ObjectToWorld, v.vertex).rgb.b)*_Wave_Quantity_V)))*_Wave_Intensity_V*v.normal));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float node_3397_ang = ((3.141592654/180.0)*_rotate);
                float node_3397_spd = 1.0;
                float node_3397_cos = cos(node_3397_spd*node_3397_ang);
                float node_3397_sin = sin(node_3397_spd*node_3397_ang);
                float2 node_3397_piv = float2(0.5,0.5);
                float2 node_3397 = (mul(i.uv0-node_3397_piv,float2x2( node_3397_cos, -node_3397_sin, node_3397_sin, node_3397_cos))+node_3397_piv);
                float4 node_8487 = _Time + _TimeEditor;
                float2 node_2081 = (node_3397+(float2(_DiffuseBack_U_Directon,_DiffuseBack_V_Direction)*_DiffuseBack_Speed*node_8487.g));
                float3 node_2165 = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_2081, _Normal)));
                float2 node_437 = (node_3397+(float2(_DiffuseFront_U_Direction,_DiffuseFront_V_Direction)*_DiffuseFront_Speed*node_8487.g));
                float3 node_7557 = UnpackNormal(tex2D(_Normal,TRANSFORM_TEX(node_437, _Normal)));
                float3 node_9234_nrm_base = node_2165.rgb + float3(0,0,1);
                float3 node_9234_nrm_detail = node_7557.rgb * float3(-1,-1,1);
                float3 node_9234_nrm_combined = node_9234_nrm_base*dot(node_9234_nrm_base, node_9234_nrm_detail)/node_9234_nrm_base.z - node_9234_nrm_detail;
                float3 node_9234 = node_9234_nrm_combined;
                float4 node_3295 = tex2D(_node_8870,TRANSFORM_TEX(node_437, _node_8870));
                float4 node_9142 = tex2D(_node_8870,TRANSFORM_TEX(node_2081, _node_8870));
                float3 normalLocal = (-1*(node_9234*(((node_3295.rgb*node_9142.rgb)+_Remap)*3.0+-2.0)));
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
////// Lighting:
                float3 finalColor = floor((max(0,dot(normalDirection,lightDirection))*(pow(max(0,dot(lightDirection,viewReflectDirection)),exp(_Glossiness))*_Glossiness_Color.rgb)) * _PosterizeLigh) / (_PosterizeLigh - 1);
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 
            #pragma target 2.0
            uniform float4 _TimeEditor;
            uniform float _Wave_Quantity_U;
            uniform float _Wave_Quantity_V;
            uniform float _Wave_Intensity_V;
            uniform float _Wave_Intensity_U;
            uniform float _Wave_Speed_U;
            uniform float _Wave_Speed_V;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_8487 = _Time + _TimeEditor;
                v.vertex.xyz += ((saturate(sin((((node_8487.g*_Wave_Speed_U)+mul(unity_ObjectToWorld, v.vertex).rgb.r)*_Wave_Quantity_U)))*_Wave_Intensity_U*v.normal)+(saturate(sin((((node_8487.g*_Wave_Speed_V)+mul(unity_ObjectToWorld, v.vertex).rgb.b)*_Wave_Quantity_V)))*_Wave_Intensity_V*v.normal));
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}

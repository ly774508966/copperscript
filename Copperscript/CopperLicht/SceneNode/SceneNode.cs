﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CL3D
{
    public class SceneNode
    {
        [PreserveCase]
        public Action<Scene> OnRegisterSceneNode;
        [PreserveCase]
        public Action<Renderer> render;

        [PreserveCase]
        public Vect3d Pos;
        [PreserveCase]
        public Mesh Mesh;
        [PreserveCase]
        public Vect3d Scale;

        [ScriptName("addAnimator")]
        public extern void addAnimator(Animator animiator);
        [ScriptName("addChild")]
        public extern void addChild(SceneNode n);

        [ScriptName("getMaterial")]
        public extern Material getMaterial(int layer);

        [ScriptName("getAbsolutePosition")]
        public extern Vect3d getAbsolutePosition();
        [ScriptName("getAbsoluteTransformation")]
        public extern Matrix4 getAbsoluteTransformation();

        [ScriptName("init")]
        protected extern void init();
    }
}

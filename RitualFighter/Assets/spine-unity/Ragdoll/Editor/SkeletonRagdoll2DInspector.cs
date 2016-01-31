﻿/*****************************************************************************
 * SkeletonRagdoll2D added by Mitch Thompson
 * Full irrevocable rights and permissions granted to Esoteric Software
*****************************************************************************/

using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

[CustomEditor(typeof(SkeletonRagdoll2D))]
public class SkeletonRagdoll2DInspector : Editor {
	SerializedProperty player, staminaBar, startingBoneName, stopBoneNames, applyOnStart, pinStartBone, enableJointCollision, gravityScale, disableIK, thickness, rotationLimit, colliderLayer, mix, rootMass, massFalloffFactor;

	void OnEnable () {
		startingBoneName = serializedObject.FindProperty("startingBoneName");
		stopBoneNames = serializedObject.FindProperty("stopBoneNames");
		applyOnStart = serializedObject.FindProperty("applyOnStart");
		pinStartBone = serializedObject.FindProperty("pinStartBone");
		gravityScale = serializedObject.FindProperty("gravityScale");
		disableIK = serializedObject.FindProperty("disableIK");
		thickness = serializedObject.FindProperty("thickness");
		rotationLimit = serializedObject.FindProperty("rotationLimit");
		colliderLayer = serializedObject.FindProperty("colliderLayer");
		mix = serializedObject.FindProperty("mix");
		rootMass = serializedObject.FindProperty("rootMass");
		massFalloffFactor = serializedObject.FindProperty("massFalloffFactor");
        staminaBar = serializedObject.FindProperty("StaminaBar");
        player = serializedObject.FindProperty("player");
    }

	public override void OnInspectorGUI () {
		EditorGUILayout.PropertyField(startingBoneName);
		EditorGUILayout.PropertyField(stopBoneNames, true);
		EditorGUILayout.PropertyField(applyOnStart);
		EditorGUILayout.PropertyField(pinStartBone);
		EditorGUILayout.PropertyField(gravityScale);
		EditorGUILayout.PropertyField(disableIK);
		EditorGUILayout.PropertyField(thickness);
		EditorGUILayout.PropertyField(rootMass);
		EditorGUILayout.PropertyField(massFalloffFactor);
        EditorGUILayout.PropertyField(staminaBar);
        EditorGUILayout.PropertyField(player);

		serializedObject.ApplyModifiedProperties();
	}

	void Header (string name) {
		GUILayout.Space(20);
		EditorGUILayout.LabelField(name, EditorStyles.boldLabel);
	}
}

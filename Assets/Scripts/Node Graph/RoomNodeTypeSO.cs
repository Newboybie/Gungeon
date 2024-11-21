using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType_", menuName = "Scriptable Objects/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    #region Header

    [Header("Only flag the RoomNodeTypes should be visible in the editor")]

    #endregion
    public bool displayOnNodeGraphEditor = true;

    #region Header

    [Header("One Type should be a Corridor")]

    #endregion Header
    public bool isCorridor;

    #region Header

    [Header("One Type should be a CorridorNS")]

    #endregion
    public bool isCorridorNS;

    #region Header

    [Header("One Type should be a CorridorEW")]

    #endregion
    public bool isCorridorEW;

    #region Header

    [Header("One Type should be an Entrance")]

    #endregion
    public bool isEntrance;

    #region Header

    [Header("One Type should be a BossRoom")]

    #endregion
    public bool isBossRoom;

    #region Header

    [Header("One Type should be Node(Unassigned")]

    #endregion
    public bool isNone;

    #region Validation

#if UNITY_EDITOR      // Only run on UNITY EDITOR
    private void OnValidate()  //  Editor-only function that unity calls when the scripts is loaded or value change
                                //   in the Inspector
    {
        HelperUtilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName),
            roomNodeTypeName);
    }
#endif

    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    public Material backgroundMaterial;
    public Material playerMaterial;
    public Material obstacleMaterial;
    public Material UI;
    public Material Target;

    private void OnMouseUp()
    {
        //Background colour
        backgroundMaterial.SetFloat("_redLevel", 0f);
        backgroundMaterial.SetFloat("_greenLevel", 0.524f);
        backgroundMaterial.SetFloat("_blueLevel", 1f);

        //Obstacle colour
        obstacleMaterial.SetFloat("_albedoRedLevel", 0f);
        obstacleMaterial.SetFloat("_albedoGreenLevel", 0f);
        obstacleMaterial.SetFloat("_albedoBlueLevel", 0.21f);

        //obstacle Emission
        obstacleMaterial.SetFloat("_redEmissionLevel", 0f);
        obstacleMaterial.SetFloat("_greenEmissionLevel", 0.528f);
        obstacleMaterial.SetFloat("_blueEmissionLevel", 0.677f);
        obstacleMaterial.SetFloat("_emissionPower", 0.26f);

        //Player Colour
        playerMaterial.SetFloat("_redAlbedoLevel", 0f);
        playerMaterial.SetFloat("_greenAlbedoLevel", 0.306f);
        playerMaterial.SetFloat("_blueAlbedoLevel", 1f);

        //Player Emission
        playerMaterial.SetFloat("_redEmissionLevel", 0f);
        playerMaterial.SetFloat("_greenEmissionLevel", 0f);
        playerMaterial.SetFloat("_blueEmissionLevel", 0.1f);
        playerMaterial.SetFloat("_emissionPower", 0.51f);

        //UI Colour
        UI.SetFloat("_redAlbedoLevel", 0f);
        UI.SetFloat("_greenAlbedoLevel", 0.475f);
        UI.SetFloat("_blueAlbedoLevel", 0.523f);

        //UI Emission
        UI.SetFloat("_redEmissionLevel", 0f);
        UI.SetFloat("_greenEmissionLevel", 0.354f);
        UI.SetFloat("_blueEmissionLevel", 0.379f);
        UI.SetFloat("_emissionPower", 0.81f);

        //Target Colour
        Target.SetFloat("_targetRed", 0f);
        Target.SetFloat("_targetGreen", 0.7f);
        Target.SetFloat("_targetBlue", 1f);
    }
}

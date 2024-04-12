using Godot;
using System;

[GlobalClass][Tool]
public partial class rez_inmateconstantscebin : Resource
{

	[Export] public string inherent_AFF_high { get; set; }
	[Export] public string inherent_AFF_med { get; set; }
	[Export] public string inherent_AFF_low { get; set; }

	//public Vector3 spritescale = new Vector3(1, 1, 1);

	[Export] public string animationpack_filepath_F { get; set; }

	public rez_inmateconstantscebin() : this("disgust", "sadness", "fear", "res://GAMEASSETS/in Fight/field units/player units/animation packs/SpriteFramesF_AnimPackCebinSprites.tres") {}

	public rez_inmateconstantscebin(string highaff, string medaff, string lowaff, string animpackfilepath)
	{
		inherent_AFF_high = highaff;
		inherent_AFF_med = medaff;
		inherent_AFF_low = lowaff;
		animationpack_filepath_F = animpackfilepath;
	}
}
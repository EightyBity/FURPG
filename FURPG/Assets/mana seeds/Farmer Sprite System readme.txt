Hi, thanks for picking up the Mana Seed Farmer Sprite System!

This is a complete paper doll system for your player sprite in a slice-of-life farming sim style game.
It features a variety of animations, hairstyles, outfits, props, and effects, as well as comprehensive guides to help you deploy them correctly.

You may add your own original hairstyle and outfit layers to this system for use in your own game.
If you would like to sell those original assets on itchio, please thoroughly read "Selling Mana Seed Compatible Assets.txt" for restrictions and contact info.

------------------------------------------------

Please note: this is not a quick and easy plug-and-play RPG Maker-type asset.
Experience with a more powerful game engine is required to be able to use the Mana Seed Farmer Sprite System.
Something like Unity, Godot, GameMaker Studio, Unreal Engine, or your own custom game engine.
You'll need to build animations with frames from different parts of the sheet (out of sequential order).
You'll need to flip some frames within the same animation.
You'll need to attach props and effects from separate sheets and line them up appropriately.
You'll need to move those props behind or in front of the character sprite as necessary.
You'll need as many as 20 layers to use everything as intended.
You'll need to assemble a paper-doll system in your game engine if you want to be able to customize your outfits in-game.
You'll need to be able to swap color palettes at run-time if you want your players to customize their outfit/hair colors.
Etcetera...

If you're still new to game development, you can come visit the Mana Seed Discord server and speak with other devs using this asset.
The Mana Seed community is friendly and helpful (so long as you don't show up with an attitude).
Hope to see you there! https://selieltheshaper.weebly.com/discord.html

------------------------------------------------

This asset is meant to have everything you need to make a playable character for a Harvest Moon or Stardew Valley style farming life sim game.
Please consult the supporting files for help setting up the animations.

Slice the farmer base sheet into 64x64 cells, and use the cell reference sheet in combo with the animation guide.
Do the same with all the other (outfit) sheets, and layer them on top in the exact same arrangement.

If an effects sheet has something like "32x32" in the filename, that's what you should slice the sheet at.
Position the props and effects as demonstrated in the animation guide, placing them behind or in front of the sprite as necessary.

------------------------------------------------

NAMING CONVENTIONS

Each Farmer Base sheet filename uses the same strict naming convention.
4 IDs, separated by underscores. For example: "fbas_01body_human_00.png"

	ID 1 (type)
		fbas (the farmer base, so you don't mix it up with other bases)

	ID 2 (layer, 6 digits)
		14over (over everything, top-most layer: front wing, magic effects)
		13head (headwear: hats, hoods, horns)
		12hair (hair)
		11face (facewear: glasses, masks)
		10cape (over all the other clothes: cloak, scarf)
		09coat (coats, jackets, vests, suspenders)
		08lwr3 (most skirts & dresses)
		07fot2 (footwear big enough go over pant legs)
		06lwr2 (pants with upper parts: overalls, shortalls)
		05shrt (most shirts & blouses)
		04lwr1 (most pants & shorts)
		03fot1 (footwear small enough to stay under the pants)
		02sock (socks, stockings, hose)
		01body (the body)
		00undr (under everything, bottom-most layer: back wing, cloak)

		Note:	Numbered versions should be distinct.
			For example: 04lwr1, 06lwr2, and 08lwr3 should all technically occupy the same "slot" on the player: You can't wear pants AND overalls.

		Another note: These layers are only suggestions. If you have a system that works better for your game, do that!

	ID 3 (unique name, 16-character max)
		human
		undies
		bra
		tanktop
		onepiece
		longshirt
		longpants
		overalls
		shorts
		shoes
		cuffedboots
		frillydressboobs (IDs with "boobs" at the end are variants with noticable boob shapes in the chest area)
		twintail
		cowboyhat
		etcetera...

	ID 4 (version number)
		00, 01, 02, 03, etc (usually color swaps)
		~ I'm only including a default color variant (00) for now, and the palettes for you to change the colors at runtime.


------------------------------------------------

I'll add more to this little help file as necessary.
Please let me know if you have any issues, or notice any errors.

Thanks again!
Seliel

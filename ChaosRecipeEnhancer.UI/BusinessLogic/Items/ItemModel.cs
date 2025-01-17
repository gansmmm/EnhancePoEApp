﻿using System.Text.Json.Serialization;

namespace ChaosRecipeEnhancer.UI.BusinessLogic.Items
{
    /// <summary>
    /// Represents a JSON response object nested within the previously mentioned response object for `get-stash-items`
    /// and `get-guild-stash-items` endpoints.
    ///
    /// The (nested) item object structure is as follows:
    ///
    /// {
    ///     "verified": false,
    ///     "w": 1,
    ///     "h": 1,
    ///     "icon": "https://web.poecdn.com/gen/image/WzI1LDE0LHsiZiI6IjJESXRlbXMvSmV3ZWxzL1NlYXJjaGluZ0V5ZSIsInciOjEsImgiOjEsInNjYWxlIjoxfV0/ff2df16522/SearchingEye.png",
    ///     "league": "Standard",
    ///     "id": "7aa804a9cb366b682d0af99ad929603bebec56f38c3e0eb2848961f45f289e1e",
    ///     "abyssJewel": true,
    ///     "name": "Whispering Horn",
    ///     "typeLine": "Searching Eye Jewel",
    ///     "baseType": "Searching Eye Jewel",
    ///     "identified": true,
    ///     "ilvl": 84,
    ///     "properties": [{ "name": "Abyss", "values": [], "displayMode": 0 }],
    ///     "requirements": [
    ///         { "name": "Level", "values": [["51", 0]], "displayMode": 0, "type": 62 }
    ///     ],
    ///     "explicitMods": [
    ///         "Adds 7 to 11 Cold Damage to Attacks",
    ///         "Adds 1 to 36 Lightning Damage to Attacks",
    ///         "4 to 9 Added Cold Damage with Bow Attacks"
    ///     ],
    ///     "descrText": "Place into an Abyssal Socket on an Item or into an allocated Jewel Socket on the Passive Skill Tree. Right click to remove from the Socket.",
    ///     "frameType": 2,
    ///     "x": 11,
    ///     "y": 22,
    ///     "inventoryId": "Stash218"
    /// },
    ///
    /// Notice how there are more fields in the example than in our defined object.
    /// </summary>
    // This class is instantiated when serialized from JSON API response.
    // ReSharper disable once ClassNeverInstantiated.Global
    public class ItemModel
    {
        // ReSharper disable once MemberCanBeProtected.Global
        public ItemModel(
            int width,
            int height,
            bool identified,
            int? itemLevel,
            int frameType,
            int x,
            int y,
            ItemInfluencesModel itemInfluencesModel,
            string icon)
        {
            Width = width;
            Height = height;
            Identified = identified;
            ItemLevel = itemLevel;
            FrameType = frameType;
            X = x;
            Y = y;
            ItemInfluencesModel = itemInfluencesModel;
            Icon = icon;
        }

        // poe json props
        [JsonPropertyName("w")] public int Width { get; }

        [JsonPropertyName("h")] public int Height { get; }

        [JsonPropertyName("identified")] public bool Identified { get; }

        [JsonPropertyName("ilvl")] public int? ItemLevel { get; }

        [JsonPropertyName("frameType")] public int FrameType { get; }

        [JsonPropertyName("x")] public int X { get; }

        [JsonPropertyName("y")] public int Y { get; }

        [JsonPropertyName("influences")] public ItemInfluencesModel ItemInfluencesModel { get; }

        // Property must be set to `public` so that it can be [de]serialized
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once MemberCanBeProtected.Global
        [JsonPropertyName("icon")] public string Icon { get; }
    }
}
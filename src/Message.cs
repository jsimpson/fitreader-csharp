using System.Collections.Generic;

namespace FitReader
{
    public class Message
    {
        internal long globalMsgNum;
        internal string name;
        internal object data;

        private Dictionary<ushort, string> Names = new Dictionary<ushort, string>()
        {
            { 0,   "fileId" },
            { 1,   "capabilities" },
            { 2,   "deviceSettings" },
            { 3,   "userProfile" },
            { 4,   "hrmProfile" },
            { 5,   "sdmProfile" },
            { 6,   "bikeProfile" },
            { 7,   "zonesTarget" },
            { 8,   "hrZone" },
            { 9,   "powerZone" },
            { 10,  "metZone" },
            { 12,  "sport" },
            { 15,  "goal" },
            { 18,  "session" },
            { 19,  "lap" },
            { 20,  "record" },
            { 21,  "event" },
            { 22,  "source" },
            { 23,  "deviceInfo" },
            { 26,  "workout" },
            { 27,  "workoutStep" },
            { 28,  "schedule" },
            { 29,  "location" },
            { 30,  "weightScale" },
            { 31,  "course" },
            { 32,  "coursePoint" },
            { 33,  "totals" },
            { 34,  "activity" },
            { 35,  "software" },
            { 37,  "fileCapabilities" },
            { 38,  "mesgCapabilities" },
            { 39,  "fieldCapabilities" },
            { 49,  "fileCreator" },
            { 51,  "bloodPressure" },
            { 53,  "speedZone" },
            { 55,  "monitoring" },
            { 72,  "trainingFile" },
            { 78,  "hrv" },
            { 80,  "antRx" },
            { 81,  "antTx" },
            { 82,  "antChannelId" },
            { 101,  "length" },
            { 103,  "monitoringInfo" },
            { 104,  "batteryInfo" },
            { 105,  "pad" },
            { 106,  "slaveDevice" },
            { 127,  "connectivity" },
            { 128,  "weatherConditions" },
            { 129,  "weatherAlert" },
            { 131,  "cadenceZone" },
            { 132,  "hr" },
            { 142,  "segmentLap" },
            { 145,  "memoGlob" },
            { 147,  "sensorInfo" },
            { 148,  "segmentId" },
            { 149,  "segmentLeaderboardEntry" },
            { 150,  "segmentPoint" },
            { 151,  "segmentFile" },
            { 159,  "watchfaceSettings" },
            { 160,  "gpsMetadata" },
            { 161,  "cameraEvent" },
            { 162,  "timestampCorrelation" },
            { 164,  "gyroscopeData" },
            { 165,  "accelerometerData" },
            { 167,  "threeDSensorCalibration" },
            { 169,  "videoFrame" },
            { 174,  "obdiiData" },
            { 177,  "nmeaSentence" },
            { 178,  "aviationAttitude" },
            { 184,  "video" },
            { 185,  "videoTitle" },
            { 186,  "videoDescription" },
            { 187,  "videoClip" },
            { 188,  "ohrSettings" },
            { 200,  "exdScreenConfiguration" },
            { 201,  "exdDataFieldConfiguration" },
            { 202,  "exdDataConceptConfiguration" },
            { 206,  "fieldDescription" },
            { 207,  "developerDataId" },
            { 208,  "magnetometerData" },
            { 65280, "mfgRangeMin" },
            { 65534, "mfgRangeMax" }
        };

        internal Message(ushort globalMsgNum, DefinitionRecord definition)
        {
            this.globalMsgNum = globalMsgNum;

            if (Names.ContainsKey(globalMsgNum))
            {
                this.name = Names[globalMsgNum];
            }
        }

        internal string Name { get => name; }
    }
}
-- Script Date: 4/15/2018 7:02 PM  - ErikEJ.SqlCeScripting version 3.5.2.75
CREATE TABLE [Packages] (
  [Id] INTEGER  NOT NULL
, [Code] text NULL
, [Destination] text NOT NULL
, [Location] text NULL
, [Description] text NOT NULL
, [HWRank] bigint  NULL
, [FAMRank] bigint  NULL
, [ADVRank] bigint  NULL
, [CRURank] bigint  NULL
, [WEDRank] bigint  NULL
, [SPA] bigint DEFAULT 0  NOT NULL
, [AMUSEMENT] bigint DEFAULT 0  NOT NULL
, [HISTORY] bigint DEFAULT 0  NOT NULL
, [CAMPING] bigint DEFAULT 0  NOT NULL
, [ENTERTAINMENT] bigint DEFAULT 0  NOT NULL
, [HealthWell] bigint DEFAULT 0  NOT NULL
, [Family] bigint DEFAULT 0  NOT NULL
, [Adventure] bigint DEFAULT 0  NOT NULL
, [Cruise] bigint DEFAULT 0  NOT NULL
, [Wedding] bigint DEFAULT 0  NOT NULL
, [LowPrice] bigint  NULL
, [HighPrice] bigint  NULL
, [DestId] bigint  NULL
, [Link] text NULL
, CONSTRAINT [sqlite_master_PK_Packages] PRIMARY KEY ([Id])
);
CREATE INDEX [IdIndex] ON [Packages] ([Id] ASC);

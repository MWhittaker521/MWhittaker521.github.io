﻿CREATE TABLE [dbo].[TravelPackages_Base] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Dest_Code]         VARCHAR (50)   DEFAULT (NULL) NULL,
    [Dest_Name]         VARCHAR (MAX)  DEFAULT (NULL) NULL,
    [Dest_Location]     VARCHAR (MAX)  DEFAULT (NULL) NULL,
    [Dest_Description]  NVARCHAR (MAX) DEFAULT (NULL) NULL,
    [HW_Rank]           INT   DEFAULT (NULL) NULL,
    [FAM_Rank]          INT   DEFAULT (NULL) NULL,
    [ADV_Rank]          INT   DEFAULT (NULL) NULL,
    [CRU_Rank]          INT   DEFAULT (NULL) NULL,
    [WED_Rank]          INT   DEFAULT (NULL) NULL,
    [AMN_SPA]           BIT            DEFAULT ((0)) NOT NULL,
    [AMN_POOL]          BIT            DEFAULT ((0)) NOT NULL,
    [AMN_SAUNA]         BIT            DEFAULT ((0)) NOT NULL,
    [AMN_NUTRITION]     BIT            DEFAULT ((0)) NOT NULL,
    [AMN_FITNESS]       BIT            DEFAULT ((0)) NOT NULL,
    [AMN_DANCE]         BIT            DEFAULT ((0)) NOT NULL,
    [AMN_ENTERTAINMENT] BIT            DEFAULT ((0)) NOT NULL,
    [AMN_FINEDINE]      BIT            DEFAULT ((0)) NOT NULL,
    [AMN_CAMPING]       BIT            DEFAULT ((0)) NOT NULL,
    [AMN_AMUSEMENT]     BIT            DEFAULT ((0)) NOT NULL,
    [AMN_MUSEM_ART]     BIT            DEFAULT ((0)) NOT NULL,
    [AMN_HISTORIC]      BIT            DEFAULT ((0)) NOT NULL,
    [AMN_BEACH]         BIT            DEFAULT ((0)) NOT NULL,
    [AMN_ZOO]           BIT            DEFAULT ((0)) NOT NULL,
    [AMN_GOLF]          BIT            DEFAULT ((0)) NOT NULL,
    [AMN_SAILING]       BIT            DEFAULT ((0)) NOT NULL,
    [AMN_SNORKELING]    BIT            DEFAULT ((0)) NOT NULL,
    [HEALTHWELL]        BIT            DEFAULT ((0)) NOT NULL,
    [FAMILY]            BIT            DEFAULT ((0)) NOT NULL,
    [ADVENTURE]         BIT            DEFAULT ((0)) NOT NULL,
    [CRUISE]            BIT            DEFAULT ((0)) NOT NULL,
    [DESTWEDDING]       BIT            DEFAULT ((0)) NOT NULL,
    [DEST_PRICE]        INT          DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


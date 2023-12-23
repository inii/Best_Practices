#!/bin/bash
./Exporter --ExportPlatform 2 \
--ProtoBufTemplatePath ../../../Demo/Config/Template/ProtoTemplate.txt \
--ProtoBufDirectory ../../../Demo/Config/ProtoBuf/ \
--ProtoBufServerDirectory ../../../Demo/Server/Hotfix/Generate/NetworkProtocol/ \
--ProtoBufClientDirectory ../../../Demo/Client/Unity/Assets/Scripts/Hotfix/Generate/NetworkProtocol/ \
--ExcelProgramPath ../../../Demo/Config/Excel/ \
--ExcelVersionFile ../../../Demo/Config/Excel/Version.txt \
--ExcelServerFileDirectory ../../../Demo/Server/Hotfix/Generate/ConfigTable/Entity/ \
--ExcelClientFileDirectory ../../../Demo/Client/Unity/Assets/Scripts/Hotfix/Generate/ConfigTable/Entity/ \
--ExcelServerBinaryDirectory ../../../Demo/Config/Binary/ \
--ExcelClientBinaryDirectory ../../../Demo/Client/Unity/Assets/Bundles/Config/ \
--ExcelServerJsonDirectory ../../../Demo/Config/Json/Server/ \
--ExcelClientJsonDirectory ../../../Demo/Config/Json/Client/ \
--ExcelTemplatePath ../../../Demo/Config/Template/ExcelTemplate.txt \
--ServerCustomExportDirectory ../../../Demo/Server/Hotfix/Generate/CustomExport/ \
--ClientCustomExportDirectory ../../../Demo/Client/Unity/Assets/Scripts/Hotfix/Generate/CustomExport
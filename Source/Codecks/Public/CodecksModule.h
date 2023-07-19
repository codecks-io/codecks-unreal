// Copyright 2022 Maschinen-Mensch UG

#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

class FCodecksModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

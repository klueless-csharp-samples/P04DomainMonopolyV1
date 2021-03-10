DddResourceBuilder.new
  .init
  .resource_key('action:player:downgrade-hotel-to-houses')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 

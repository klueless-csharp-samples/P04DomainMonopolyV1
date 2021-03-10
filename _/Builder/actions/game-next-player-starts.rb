DddResourceBuilder.new
  .init
  .resource_key('action:game:next-player-starts')
  .language(:csharp)
  .template(:action)
  .generate(:overwrite) # options: :write, :overwrite, :diff 
